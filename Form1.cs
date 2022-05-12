using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHVRacing
{
    public partial class Form1 : Form
    {
        int playerspeed = 25;
        int policespeed = 12;
        int points;
        int backgroundspeed = 35;
        int gametime;
        int carimage;

        bool goleft, goright;

        Random R = new Random();
        Random carposition = new Random();



        public Form1()
        {
            InitializeComponent();
            resetgame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void downkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if(e.KeyCode==Keys.Left)
            {
                goleft = true;
            }

        }

        private void TimeEvent(object sender, EventArgs e)
        {
            gameoverbox.Visible = false;
            score.Text = "Score: " + points;
            points++;


            if(goleft==true && polonez.Left >10)
            {
                polonez.Left -= playerspeed;
            }
            if (goright == true && polonez.Left < 490)
            {
                polonez.Left += playerspeed;
            }
            //to zadziała tak że gracz nie opuści panelu a nawet nie opuści lokalizacji. 4-494

            background1.Top += backgroundspeed;
            background2.Top += backgroundspeed; //poprzez int backgroundspeed będą się oba te tła przesuwać w dół

            if (background2.Top > 607)
            {
                background2.Top = -607;
            }
            if (background1.Top > 607)
            {
                background1.Top = -607;
            }

            p1.Top += policespeed;
            p2.Top += policespeed;

            if(p1.Top > 610)
            {
                changecar(p1);      
            }
            if (p1.Top > 610)
            {
                changecar(p2);
            }

            if (polonez.Bounds.IntersectsWith(p1.Bounds) || polonez.Bounds.IntersectsWith(p2.Bounds)) //kolizje
            {
                gameover();
            }
            if(points < 500)
            {
                policespeed = 15;
                backgroundspeed = 30;
            }
            if(points > 500 && points <2000)
            {
                policespeed = 44;
                backgroundspeed = 45;
            }
            if (points > 2000)
            {
                policespeed = 60;
                backgroundspeed = 60;
            }
        } 

        private void upkey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
        private void changecar(PictureBox change)       //picturebox jest przesłany do tej funkcji
        {
           carimage = R.Next(1,2);     //losuje licze od 1 do 2 aby zmieniac radiowozy
            if(carimage == 1)
                change.Image = Properties.Resources.police_lights;
            if(carimage == 2)
                change.Image = Properties.Resources.police_lights_21;

            change.Top = carposition.Next(100,400) * -1;

            if((string)change.Tag == "left")
            {
                change.Left = carposition.Next(3, 194);
            }
            if ((string)change.Tag == "right")
            {
                change.Left = carposition.Next(300, 494);
            }


            
        }
        private void gameover()
        {
            playsound();
            timer1.Stop();
            explosion.Visible = true;
            polonez.Controls.Add(explosion); //parent do polonez żeby ustawić lokalizacje na nim
            explosion.Location = new Point(-8,5);
            explosion.BackColor = Color.Transparent;
            gameoverbox.Visible = true;
            
            StartButton.Enabled = true;
        }
        private void resetgame()
        {
            StartButton.Enabled = false;
            explosion.Visible = false;
            goleft = false;
            goright = false;
            backgroundspeed = 10;
            policespeed = 13;

            p1.Top = carposition.Next(200, 500) * -1;   //losuje połozenie radiowozu, mnozenie razy -1 żeby wyglądało że porusza się w dół
            p1.Left = carposition.Next(3, 194);         //ograniczenie gdzie może się pojawic radiowóz

            p2.Top = carposition.Next(200, 500) * -1;
            p2.Left = carposition.Next(300, 494);

            timer1.Start();
        }
        private void playmusic()
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            resetgame();
        }

        private void playsound()
        {
            System.Media.SoundPlayer soundcrash = new System.Media.SoundPlayer(Properties.Resources.Car_Crash_Sound_Effects);//nowa instancja ten przestrzeni nazw sysytem media 
            soundcrash.Play();

        }

    }
}
