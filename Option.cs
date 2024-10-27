using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace flapp
{
    public partial class Option : Form
    {
        private int _time;
        public static int Gravity1=3;
        public static  int Jumphigh=3;
        private int _reversetime = 50;
        public static int Speed=5;
       private bool _jumpingUp;
       private bool _jumpingDown;
        public Option()
        {
            InitializeComponent();
            label3.Text = @"Gravity : " + Gravity1;
            label4.Text = @"game Speed : " + Speed;
            label5.Text = @"Jump High : " + Jumphigh;
        }
        Game _game = new Game();
        
       
        private void Option_start_button(object sender, EventArgs e)
        {

            _game.colo_up.Location = new Point(742, 380);
            _game.colo_downn.Location = new Point(375, -192);
            Close();
            _game.Show();
        }

        private void Gravity(PictureBox player)
        {
            if (player.Location.Y <= 350 )
            {
                player.Top += _time*Gravity1/5;
            }

            if (player.Location.Y > 350 )
            {
                player.Location = new Point(player.Location.X, 350);
            }

            if (Gravity1 == 0)
            {
                _time = 0;
            }
            
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
        }
        private void Gravity_minus(object sender, EventArgs e)
        { 
            timer1.Start();
            Gravity1--;
            label3.Text = @"Gravity : "+Gravity1;
            _game.GravityGame=  Gravity1;
        }
        private void Gravity_plus(object sender, EventArgs e)
        {
            timer1.Start();
            Jumphigh = _game.JumpHigh;
            Gravity1++;
            label3.Text = @"Gravity : "+Gravity1;
           _game.GravityGame =Gravity1;
        }
        private void Game_loop(object sender, ElapsedEventArgs e)
        {
            _time++;
            if(!_jumpingUp||!_jumpingDown)
                Gravity(player_pictureBox);
          

        }
        private void Jump_button(object sender, EventArgs e)
        { 
            _jumpingUp = true;
            _reversetime = 15;
            _time = 0;
        }
        private void Land_button(object sender, EventArgs e)
        {
            _jumpingDown = true;
            _reversetime = 15;
            _time = 0;
          
        }
        private void Speed_plus(object sender, EventArgs e)
        {
            Speed++;
            label4.Text = @"game Speed : " + Speed;
            _game.ColumnSpeed= Speed;
        }
        private void Speed_minus(object sender, EventArgs e)
        {
            if(Speed>1)
            { 
                Speed--;
                label4.Text = @"game Speed : " + Speed;
                _game.ColumnSpeed= Speed;
            }
        }
        
        private void JumpHigh_plus(object sender, EventArgs e)
        {
            if(Jumphigh<6)
            {
                Jumphigh++;
                label5.Text = @"Jump High : " + Jumphigh;
                _game.JumpHigh = Jumphigh;
            }
        }

        private void JumpHigh_minus(object sender, EventArgs e)
        {
            if(Jumphigh>1)
            {
                Jumphigh--;
                label5.Text = @"Jump High : " + Jumphigh;
                _game.JumpHigh = Jumphigh;
            }
        }
        
        public void JumpUp(PictureBox player)
        {
                if (_reversetime>0)
                {
                    player.Top -= (_reversetime/3)* Jumphigh-Gravity1;
                    _reversetime--;
                }

                if (_reversetime == 0)
                {
                    _jumpingUp = false;
                }
                if (player.Location.Y < 1)
                {
                    player.Location = new Point(player.Location.X, 1);
                }
                if (player.Location.Y > 350 )
                {
                    player.Location = new Point(player.Location.X, 350);
                }
                
            
                _time = 0;
        }
        public void JumpDown(PictureBox player)
        {
            
                if (_reversetime>0)
                {
                    player.Top += (_reversetime)* Jumphigh/6-Gravity1;
                    _reversetime--;
                }

                if (_reversetime == 0)
                {
                    _jumpingDown = false;
                }
                if (player.Location.Y < 1)
                {
                    player.Location = new Point(player.Location.X, 1);
                }
                if (player.Location.Y > 350 )
                {
                    player.Location = new Point(player.Location.X, 350);
                }
                
        }
        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_jumpingUp)
            {
                JumpUp(player_pictureBox);
            }

            if (_jumpingDown)
            {
                JumpDown(player_pictureBox);
            }

            Random random = new Random();
            int r = random.Next(50, 255);
            int g = random.Next(50, 255);
            int b = random.Next(50, 255);

            label2.ForeColor=Color.FromArgb(r, g, b);
        }
    }
}