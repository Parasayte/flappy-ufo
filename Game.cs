using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace flapp
{
    public partial class Game : Form
    {
        private int _reversetime;
        private bool JumpingUp;
        private bool JumpingDown;
        public int ColumnSpeed = Option.Speed;
        public int GravityGame =Option.Gravity1;
        public int JumpHigh = Option.Jumphigh;
        private int _gravityTime;
        private int _playerScore;
        public Game()
        {
            InitializeComponent();
        }
        
        private void Stages()
        {
            switch (_playerScore)
            {
                case 10:
                    ColumnSpeed += 3;
                    break;
                case 20:
                    ColumnSpeed += 3;
                    break;
                case 30:
                    ColumnSpeed += 3;
                    break;
                case 40:
                    GravityGame ++;
                    ColumnSpeed += 3;
                    break;
                case 50:
                    GravityGame ++;
                    ColumnSpeed += 3;
                    break;
                case 60:
                    ColumnSpeed += 3;
                    break;
            }
        }
        private static bool Crashing(PictureBox p,PictureBox c )
        {
            if (p.Bounds.IntersectsWith(c.Bounds))
            {
                return true;
            }
            return false;
        }

        private void Gravity(PictureBox player)
        {
            if (player.Location.Y <= 390 )
            {
                player.Top += _gravityTime*GravityGame/5;
               
            }

            if (player.Location.Y > 390 )
            {
                player.Location = new Point(player.Location.X, 390);
            }

            if (GravityGame == 0)
            {
                _gravityTime = 0;
            }
            
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
        }
        private void Game_loop(object sender, ElapsedEventArgs e)
        {
            _gravityTime++;
            frames_counter.Text = @"Cool : " + _gravityTime;
            label1.Text = "Arch : " + _reversetime;  
            UpColumn_movement(colo_up);
            DownColumn_movement(colo_downn);
            if (Crashing(player, colo_up) || Crashing(player, colo_downn))
            {
                restart_button.Enabled = true;
                GameOver();
            }
           
            if(!JumpingUp||!JumpingDown)
            {
                Gravity(player);
            }
            
        }
      
        public void JumpDown(PictureBox player)
        {
            
            if (_reversetime>0)
            {
                player.Top += (_reversetime/3)* JumpHigh-GravityGame;
                _reversetime--;
            }

            if (_reversetime == 0)
            {
                JumpingDown = false;
            }
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
            if (player.Location.Y > 390 )
            {
                player.Location = new Point(player.Location.X, 390);
            }

            _gravityTime = 0;

        }
        public void JumpUp(PictureBox player)
        {
            if (_reversetime>0)
            {
                player.Top -= (_reversetime/3)* JumpHigh-GravityGame;
                _reversetime--;
            }

            if (_reversetime == 0)
            {
                JumpingUp = false;
            }
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
            if (player.Location.Y > 390 )
            {
                player.Location = new Point(player.Location.X, 390);
            }
                
            
           _gravityTime = 0;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                JumpingUp = true;
                _reversetime = 15;
               
                JumpingUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                JumpingDown = true;
                _reversetime = 15;
               
                JumpingDown = true;
            }
        }
        private void ScorePointer( )
        {
            _playerScore++;
            scorelabel.Text = @"Score : " + _playerScore;
            Stages();
        }
        private void UpColumn_movement(PictureBox column)
        {
            column.Left -= ColumnSpeed;
            if (column.Left < 0)
            {
                ReplaceColomnUp(column);
                ScorePointer();
            }
        }
        private void DownColumn_movement(PictureBox column )
        {
            column.Left -= ColumnSpeed;
            if (column.Left < 0)
            {
              ReplaceColomnDown(column);
              ScorePointer();
            }
        }

        private void ReplaceColomnUp(PictureBox colomn )
        {
            Random random = new Random();
            int rnd=random.Next(249, 350);
            colomn.Left = 800;
            colomn.Top = +rnd;
        }

        private void ReplaceColomnDown(PictureBox colomn )
        {
            Random random = new Random();
            int rnd=random.Next(0, 209);
            colomn.Left = 800;
            colomn.Top = -rnd;
        }
        private void GameOver()
        {   
            menu_button.Visible=true;
            option_button.Enabled = true;
            game_over.Visible = true;
            restart_button.Visible = true;
            timer1.Stop();
            timer2.Stop();
            option_button.Visible = true;
        }
        private void Restart()
        {
            option_button.Visible = false;
            option_button.Enabled = false;
            menu_button.Visible = false;
            restart_button.Enabled = false;
            game_over.Visible = false;
            restart_button.Visible = false;
            timer1.Start();
            timer2.Start();
            _playerScore = 0;
            
        Close();
        Game game = new Game();
        game.Show();
        }
        private void Menu_button(object sender, EventArgs e)
        { 
            Close();
            Menu m = new Menu();
            m.Show();
        }
        private void Restart_button(object sender, EventArgs e)
        {
            Restart();
        }
        private void Option_button(object sender, EventArgs e)
        {
            Close();
            Option o = new Option();
            o.Show();
        }

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            _gravityTime++;
            if (JumpingUp)
            { 
                JumpUp(player);
            }
            if (JumpingDown)
            { 
                JumpDown(player);
            }
        }
    }
}
