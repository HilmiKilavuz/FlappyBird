using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//bu proje de flappy bird oyununun basit bir versiyonunu yaptım. hangi yerde ne yapıldığı yorum satırları ile açıklanmıştır.
namespace FlappyBird
{
    public partial class Form1 : Form
    {
        //kuşun aşağı düşme hızını ve boruların haraket hızını başta değişken olarak atadım.Başlangıç skorunu da tanımladım.
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        
        

        public Form1()
        {
            InitializeComponent();
        }

     

      

        private void gameTimerEvet(object sender, EventArgs e)
        {
            //burda değşken olarak atadığımız hız değerlerini boru ve kuşlara verdik.
            flappyBird.Top += gravity;
            pipeTop1.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeTop3.Left -= pipeSpeed;

            pipeBottom2.Left -= pipeSpeed;
            pipeBottom3.Left -= pipeSpeed;
            pipeBottom1.Left -= pipeSpeed;
            ScoreValue.Text = score.ToString();
            // bu kısımda boruların ekrandan çıktıktan sonra sağ taraftan tekrar çıkmasını sağladım.ve ekrandan çıktıktan sonra skor değerini arttırdım.

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
            
         
            //bu bölümde eğer kuş boru veya yere değerse oyunun bitme fonksiyonunun çalışmasını sağladım.

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
            // bu kısımda kuş tavana çarpınca yanmasını sağladım.
         
            if (flappyBird.Top<0)
            {
                endGame();

            }

            


        }
        // burada eğer space tuşuna basılırsa yükselmesini sağladım. bunu sağlamak için yer çekimini terse çevirdim.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys. Space)
            {
                gravity = -5;

            }

        }
        //burada ise tuş bırakıldığında yer çekimini eski değerine dönmesine sağladım.
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;

            }

        }
        //bu fonksiyon oynunun bittiğini gösteren menün açılmasını ve timer ın durmasını sağlıyor.
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
        // eğer restart tuşuna basılırsa oyunun tekrar başlamasını sağlıyor.
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
