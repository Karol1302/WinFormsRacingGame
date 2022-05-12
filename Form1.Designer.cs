
namespace OHVRacing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameoverbox = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.polonez = new System.Windows.Forms.PictureBox();
            this.background2 = new System.Windows.Forms.PictureBox();
            this.background1 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polonez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.gameoverbox);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.polonez);
            this.panel1.Controls.Add(this.background2);
            this.panel1.Controls.Add(this.background1);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 607);
            this.panel1.TabIndex = 0;
            // 
            // gameoverbox
            // 
            this.gameoverbox.Image = ((System.Drawing.Image)(resources.GetObject("gameoverbox.Image")));
            this.gameoverbox.Location = new System.Drawing.Point(184, 246);
            this.gameoverbox.Name = "gameoverbox";
            this.gameoverbox.Size = new System.Drawing.Size(179, 136);
            this.gameoverbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameoverbox.TabIndex = 1;
            this.gameoverbox.TabStop = false;
            this.gameoverbox.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // explosion
            // 
            this.explosion.Image = ((System.Drawing.Image)(resources.GetObject("explosion.Image")));
            this.explosion.Location = new System.Drawing.Point(386, 329);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(87, 121);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 1;
            this.explosion.TabStop = false;
            this.explosion.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // p2
            // 
            this.p2.Image = global::OHVRacing.Properties.Resources.police_lights_21;
            this.p2.Location = new System.Drawing.Point(494, 26);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(63, 118);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Tag = "right";
            this.p2.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // p1
            // 
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(4, 44);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(61, 118);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 1;
            this.p1.TabStop = false;
            this.p1.Tag = "left";
            this.p1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // polonez
            // 
            this.polonez.BackColor = System.Drawing.Color.Black;
            this.polonez.Image = ((System.Drawing.Image)(resources.GetObject("polonez.Image")));
            this.polonez.Location = new System.Drawing.Point(235, 453);
            this.polonez.Name = "polonez";
            this.polonez.Size = new System.Drawing.Size(61, 137);
            this.polonez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.polonez.TabIndex = 1;
            this.polonez.TabStop = false;
            this.polonez.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // background2
            // 
            this.background2.Image = ((System.Drawing.Image)(resources.GetObject("background2.Image")));
            this.background2.Location = new System.Drawing.Point(0, 0);
            this.background2.Name = "background2";
            this.background2.Size = new System.Drawing.Size(560, 607);
            this.background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background2.TabIndex = 0;
            this.background2.TabStop = false;
            // 
            // background1
            // 
            this.background1.Image = ((System.Drawing.Image)(resources.GetObject("background1.Image")));
            this.background1.Location = new System.Drawing.Point(0, -607);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(560, 607);
            this.background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background1.TabIndex = 0;
            this.background1.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(242, 651);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(560, 23);
            this.score.TabIndex = 2;
            this.score.Text = "Score: 0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press left and right to move the Polonez\r\nEscape from the Police and watch out, b" +
    "ecause the Polonez is beast!\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.TimeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 811);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OHV RACING";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downkey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.upkey);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameoverbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polonez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox polonez;
        private System.Windows.Forms.PictureBox background2;
        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox gameoverbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
    }
}

