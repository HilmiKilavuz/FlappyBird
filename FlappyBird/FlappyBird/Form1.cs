using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        
        

        public Form1()
        {
            InitializeComponent();
        }

     

      

        private void gameTimerEvet(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeTop1.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeTop3.Left -= pipeSpeed;

            pipeBottom2.Left -= pipeSpeed;
            pipeBottom3.Left -= pipeSpeed;
            pipeBottom1.Left -= pipeSpeed;
            ScoreValue.Text = score.ToString();

            if (pipeBottom1.Left< -150)
            {
                pipeBottom1.Left = 1000;
                score++;

            }
            if (pipeBottom2.Left < -150)
            {
                pipeBottom2.Left = 1000;
                score++;


            }
            if (pipeBottom3.Left < -150)
            {
                pipeBottom3.Left = 1000;
                score++;


            }
            if (pipeTop1.Left < -150)
            {
                pipeTop1.Left = 1000;
               

            }
            if (pipeTop2.Left < -150)
            {
                pipeTop2.Left = 1000;
                

            }
            if (pipeTop3.Left < -150)
            {
                pipeTop3.Left = 1000;
               

            }
            
         


            if (flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds)||
                flappyBird.Bounds.IntersectsWith(pipeBottom1.Bounds)||
                flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop3.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeBottom3.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();

            }
         
            if (flappyBird.Top<0)
            {
                endGame();

            }

            


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys. Space)
            {
                gravity = -5;

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;

            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOverScore.Text="Score:"+score;
            gameOverScore.Visible = true;
            GameOver.Visible = true;
            RestartButton.Visible = true;
            scoreLabel.Visible = false;
            ScoreValue.Visible = false;

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
