using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndlessTanks
{
    public partial class EndlessTanks : Form
    {
        public EndlessTanks()
        {
            InitializeComponent();
            labelGameOver.Visible = false;
        }

        bool up, down, right;
        Random random = new Random();
        int score;

        private void StartGame(object sender, EventArgs e)
        {
            MovePlayer();
            Block();
            Enemys();
            Bullets();
            ResultGame();
        }

        void ResultGame()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) ||
                        player.Bounds.IntersectsWith(en1.Bounds) ||
                        player.Bounds.IntersectsWith(en2.Bounds) ||
                        player.Bounds.IntersectsWith(enemy1.Bounds) ||
                        player.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        labelGameOver.Visible = true;
                        timer1.Stop();
                    }
                }
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Down:
                    down = false;
                    break;
                case Keys.Right:
                    right = false;
                    break;
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    up = true;
                    break;
                case Keys.Down:
                    down = true;
                    break;
                case Keys.Right:
                    right = true;
                    break;
            }
        }

        void Block()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (x.Left < -150)
                    {
                        x.Left = 700;
                        score += 1;
                        scoreLabel.Text = "Score : " + score;
                    }
                    if (right == true)
                    {
                        x.Left -= 5;
                    }
                }
            }
        }
        void MovePlayer()
        {
            if (down == true)
            {
                if (player.Top < 220)
                {
                    player.Top += 5;
                }
            }
            if (up == true)
            {
                if (player.Top > 50)
                {
                    player.Top -= 5;
                }
            }
        }

        void Bullets()
        {
            bullet.Left += 20;
            if (bullet.Left > 400)
            {
                bullet.Left = player.Left;
                bullet.Top = player.Top + 10;
                bullet.Image = Properties.Resources.bull_1_;
            }
            en1.Left -= 10;
            if (en1.Left < 10)
            {
                en1.Image = Properties.Resources.bull2_1_;
                en1.Left = enemy1.Left; 
                en1.Top = enemy1.Top + 8;
            }
            en2.Left -= 10;
            if (en2.Left < 10)
            {
                en2.Image = Properties.Resources.bull2_1_;
                en2.Left = enemy2.Left;
                en2.Top = enemy2.Top + 8;
            }
        }

        void Enemys()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    x.Left -= 6;
                    if (x.Left < 10)
                    {
                        int i;
                        i = random.Next(50, 600);
                        x.Location = new Point(800, i);
                    }
                    if (bullet.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 5;
                        scoreLabel.Text = "Score : " + score;
                        x.Left = 800;
                    }
                }
            }
        }
    }
}
