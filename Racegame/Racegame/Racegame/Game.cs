using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racegame
{
    public partial class Game : Form
    {
<<<<<<< HEAD
        
        ////////////////////
        ///////////////////
        //Player one
        Bitmap Backbuffer;
=======

         Bitmap Backbuffer;
>>>>>>> origin/master

        const int BallAxisSpeed = 2;

        Point BallPos = new Point(30, 30);
        Point BallSpeed = new Point(BallAxisSpeed, BallAxisSpeed);
        const int BallSize = 30;
        
        /////////////////////////
        /////////////////////////
        //player two 
        //Bitmap backbuffer2;
        const int CarTwoAxisSpeed = 2;
        Point CarTwoPos = new Point(60, 60);
        Point CarTwoSpeed = new Point(CarTwoAxisSpeed, CarTwoAxisSpeed);
        const int CarTwoSize = 30;
 

        public Game()
        {
<<<<<<< HEAD
            InitializeComponent();
             
=======
           InitializeComponent();

>>>>>>> origin/master
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            Timer GameTimer = new Timer();
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);
            GameTimer.Start();

            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyDown += new KeyEventHandler(PlayerTwo_keydown);
        }
       void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                BallSpeed.X = -BallAxisSpeed;
            else if (e.KeyCode == Keys.Right)
                BallSpeed.X = BallAxisSpeed;
            else if (e.KeyCode == Keys.Up)
                BallSpeed.Y = -BallAxisSpeed; // Y axis is downwards so -ve is up.
            else if (e.KeyCode == Keys.Down)
                BallSpeed.Y = BallAxisSpeed;
        }
<<<<<<< HEAD
        void PlayerTwo_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                CarTwoSpeed.X = -CarTwoAxisSpeed;
            else if (e.KeyCode == Keys.D)
                CarTwoSpeed.X = CarTwoAxisSpeed;
            else if (e.KeyCode == Keys.W)
                CarTwoSpeed.Y = -CarTwoAxisSpeed;
            else if (e.KeyCode == Keys.S)
                CarTwoSpeed.Y = CarTwoAxisSpeed;
        }
        void Game_Paint(object sender, PaintEventArgs e)
=======
        void Form1_Paint(object sender, PaintEventArgs e)
>>>>>>> origin/master
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }
        }
      

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        void Draw()
        {
            if (Backbuffer != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    g.Clear(Color.White);
                    g.FillEllipse(Brushes.Black, BallPos.X - BallSize / 2, BallPos.Y - BallSize / 2, BallSize, BallSize);
                    g.FillEllipse(Brushes.Red, CarTwoPos.X - CarTwoSize / 2, CarTwoPos.Y - CarTwoSize / 2, CarTwoSize, CarTwoSize);

                }
                
                Invalidate();
            }
        }
        void GameTimer_Tick(object sender, EventArgs e)
        {
            BallPos.X += BallSpeed.X;
            BallPos.Y += BallSpeed.Y;
            CarTwoPos.X += CarTwoSpeed.X;
            CarTwoPos.Y+= CarTwoSpeed.Y;

            Draw();

            // TODO: Add the notion of dying (disable the timer and show a message box or something)
        }

    }
}
