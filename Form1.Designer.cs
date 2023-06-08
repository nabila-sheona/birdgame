namespace flappy_bird_1._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pipebottom
            // 
            this.pipebottom.BackColor = System.Drawing.Color.Transparent;
            this.pipebottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipebottom.Image = global::flappy_bird_1._0.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(329, 412);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(98, 177);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.BackColor = System.Drawing.Color.Transparent;
            this.pipeup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeup.Image = global::flappy_bird_1._0.Properties.Resources.pipe2;
            this.pipeup.Location = new System.Drawing.Point(495, -6);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(94, 156);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 2;
            this.pipeup.TabStop = false;
            this.pipeup.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Image = global::flappy_bird_1._0.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-16, 533);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1654, 125);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.BackColor = System.Drawing.Color.Transparent;
            this.flappybird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flappybird.Image = global::flappy_bird_1._0.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(62, 247);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(80, 60);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 5;
            this.flappybird.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 40;
            this.gametimer.Tick += new System.EventHandler(this.timer1events);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappy_bird_1._0.Properties.Resources.pixels_video_games_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.pipebottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappybird;
        public System.Windows.Forms.Timer gametimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

