using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;




namespace flappy_bird_1._0
{
    public partial class Form1 : Form
    {

        int pipespeed = 5;
        int gravity = 0;
        int score = 0;
        bool gameover = false;
        Random rmd=new Random();
       
        public Form1()
        {
            InitializeComponent();
            // Create a SoundPlayer instance
            SoundPlayer player = new SoundPlayer();

            // Set the path to your background music file
            player.SoundLocation = "D:\\freshman summer\\flappy_bird_1.0\\Resources\\cheerful-cinematic-song-without-solo-guitar-10709.wav";

            // Play the music
            player.PlayLooping();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1events(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipeup.Left -= pipespeed;
            label1.Text = "Score: " + score;
            if (gravity!=0 && pipebottom.Left < -100)
            {
                pipebottom.Left = rmd.Next(300, 500);
                // pipebottom.Top += 30;
                //pipebottom.Top -= 50;
                //&& pipespeed>13

                score++;
            }

            else if (gravity == 0 && pipebottom.Left < -30)
            {
                pipebottom.Left = rmd.Next(300,500);
              
            }

            if (gravity != 0 && pipeup.Left < -130)
            {
                pipeup.Left = rmd.Next(400, 700);
                score++;
            }
            else if (gravity == 0 && pipeup.Left < -50)
            {
                pipeup.Left = rmd.Next(400, 700);

            }
            if (ground.Left < -60)
            {
         

            }



            if (flappybird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeup.Bounds) ||
                flappybird.Bounds.IntersectsWith(ground.Bounds) || flappybird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }

            if (score > 5)
            {
                pipespeed = 8;
            }
            else if (score > 10)
            {
                pipespeed = 10;
            }

            else if (score > 15)
            {
                pipespeed = 13;
            }
            else if (score > 20)
            {
                pipespeed = 15;
            }
            else if (score > 25)
            {
                pipespeed = 17;
            }
            else if (score > 30)
            {
                pipespeed = 20;
            }



        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Space)
            {

                gravity = -15;

                if (score > 30)
                {
                    gravity = -18;
                }
            }
        }


        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 15;
                if (score > 30)
                {
                    gravity = 18;
                }
            }

            if (e.KeyCode == Keys.R && gameover)
            {

                restartgame();
                
            }
        }

        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gametimer.Stop(); // stop the main timer
            label1.Text += "  Game over!!! Press R to retry" ; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
            gameover = true;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
           // gametimer.Start();
        }
    
    private void restartgame()
        {

            gameover = false;
            flappybird.Location = new Point(70, 147);
            pipeup.Left = 287;
            pipebottom.Left = 247;
            score= 0;
            pipespeed = 5;
            gravity = 0;
            label1.Text = "Score: 0";
          
                gametimer.Start();
            



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void SOUND(object sender, EventArgs e)
        {

        }
    }

}
