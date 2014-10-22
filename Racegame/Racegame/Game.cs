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
        Bitmap Backbuffer;

        Vehicle vehicle1 = new Vehicle(2);

        public Game()
        {
            InitializeComponent();

            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            Core GameTimer = new Core();

            this.ResizeEnd += new EventHandler(Game_CreateBackBuffer);
            this.Load += new EventHandler(Game_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Game_Paint);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                Vehicle.BallSpeed.X = -vehicle1.BallAxisSpeed;
            else if (e.KeyCode == Keys.Right)
                vehicle1.BallSpeed.X = vehicle1.BallAxisSpeed;
            else if (e.KeyCode == Keys.Up)
                vehicle1.BallSpeed.Y = -vehicle1.BallAxisSpeed; // Y axis is downwards so -ve is up.
            else if (e.KeyCode == Keys.Down)
                vehicle1.BallSpeed.Y = vehicle1.BallAxisSpeed;
        }

        void Game_Paint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }
        }

        void Game_CreateBackBuffer(object sender, EventArgs e)
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
                }

                Invalidate();
            }
        }

        public void GameTimer_Tick(object sender, EventArgs e)
        {
            BallPos.X += BallSpeed.X;
            BallPos.Y += BallSpeed.Y;


            Draw();

            // TODO: Add the notion of dying (disable the timer and show a message box or something)
        }
    }
}
