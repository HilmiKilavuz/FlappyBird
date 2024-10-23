namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreValue = new System.Windows.Forms.Label();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            this.gameOverScore = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(65, 281);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(67, 57);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeBottom1.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom1.Image")));
            this.pipeBottom1.Location = new System.Drawing.Point(409, 461);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(117, 180);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 1;
            this.pipeBottom1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-19, 535);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1468, 217);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 19);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(120, 37);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "SCORE:";
            // 
            // pipeTop1
            // 
            this.pipeTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pipeTop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeTop1.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop1.Image")));
            this.pipeTop1.Location = new System.Drawing.Point(409, -28);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(117, 343);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 5;
            this.pipeTop1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvet);
            // 
            // ScoreValue
            // 
            this.ScoreValue.AutoSize = true;
            this.ScoreValue.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreValue.Location = new System.Drawing.Point(138, 19);
            this.ScoreValue.Name = "ScoreValue";
            this.ScoreValue.Size = new System.Drawing.Size(34, 37);
            this.ScoreValue.TabIndex = 6;
            this.ScoreValue.Text = "0";
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pipeTop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeTop2.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop2.Image")));
            this.pipeTop2.Location = new System.Drawing.Point(858, -199);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(117, 343);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 7;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeBottom2.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom2.Image")));
            this.pipeBottom2.Location = new System.Drawing.Point(858, 280);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(117, 300);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 8;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeBottom3.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom3.Image")));
            this.pipeBottom3.Location = new System.Drawing.Point(1256, 351);
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.Size = new System.Drawing.Size(117, 218);
            this.pipeBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom3.TabIndex = 9;
            this.pipeBottom3.TabStop = false;
            // 
            // pipeTop3
            // 
            this.pipeTop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pipeTop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeTop3.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop3.Image")));
            this.pipeTop3.Location = new System.Drawing.Point(1256, -173);
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.Size = new System.Drawing.Size(117, 343);
            this.pipeTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop3.TabIndex = 10;
            this.pipeTop3.TabStop = false;
            // 
            // gameOverScore
            // 
            this.gameOverScore.AutoSize = true;
            this.gameOverScore.BackColor = System.Drawing.Color.Red;
            this.gameOverScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOverScore.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverScore.Location = new System.Drawing.Point(151, 317);
            this.gameOverScore.Name = "gameOverScore";
            this.gameOverScore.Size = new System.Drawing.Size(178, 66);
            this.gameOverScore.TabIndex = 11;
            this.gameOverScore.Text = "Score:";
            this.gameOverScore.Visible = false;
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Red;
            this.GameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameOver.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GameOver.Location = new System.Drawing.Point(91, 196);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(299, 66);
            this.GameOver.TabIndex = 12;
            this.GameOver.Text = "Game Over";
            this.GameOver.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.AutoSize = true;
            this.RestartButton.BackColor = System.Drawing.Color.Red;
            this.RestartButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RestartButton.Location = new System.Drawing.Point(109, 464);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(263, 66);
            this.RestartButton.TabIndex = 13;
            this.RestartButton.Text = "Try Again";
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(279, 348);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 625);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.gameOverScore);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.pipeBottom1);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ScoreValue);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label ScoreValue;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.PictureBox pipeTop3;
        private System.Windows.Forms.Label gameOverScore;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label RestartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

