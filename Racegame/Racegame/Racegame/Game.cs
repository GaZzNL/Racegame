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

        ////////////////////
        ///////////////////
        //Player one

        /*const int CarOneAxisSpeed = 2;

        Point CarOnePos = new Point(30, 30);
        Point CarOneSpeed = new Point(CarOneAxisSpeed, CarOneAxisSpeed);
        const int CarOneSize = 30;
        */
        /////////////////////////
        /////////////////////////
        //player two 
        //Bitmap backbuffer2;
        /*const int CarTwoAxisSpeed = 2;
        Point CarTwoPos = new Point(60, 60);
        Point CarTwoSpeed = new Point(CarTwoAxisSpeed, CarTwoAxisSpeed);
        const int CarTwoSize = 30;*/

        //De voertuigen worden gemaakt
        Vehicle vehicle1 = new Vehicle(60);
        Vehicle vehicle2 = new Vehicle(30);

        public Game()
        {
            InitializeComponent();
             
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyDown += new KeyEventHandler(PlayerTwo_keydown);
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                vehicle1.Speed.X = -vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Right)
                vehicle1.Speed.X = vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Up)
                vehicle1.Speed.Y = -vehicle1.AxisSpeed; // Y axis is downwards so -ve is up.
            else if (e.KeyCode == Keys.Down)
                vehicle1.Speed.Y = vehicle1.AxisSpeed;
        }

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

        void Form1_Paint(object sender, PaintEventArgs e)

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
                    g.FillEllipse(Brushes.Black, CarOnePos.X - CarOneSize / 2, CarOnePos.Y - CarOneSize / 2, CarOneSize, CarOneSize);
                    g.FillEllipse(Brushes.Red, CarTwoPos.X - CarTwoSize / 2, CarTwoPos.Y - CarTwoSize / 2, CarTwoSize, CarTwoSize);

                }
                
                Invalidate();
            }
        }
        public void GameTimer_Tick(object sender, EventArgs e)
        {
            CarOnePos.X += CarOneSpeed.X;
            CarOnePos.Y += CarOneSpeed.Y;
            CarTwoPos.X += CarTwoSpeed.X;
            CarTwoPos.Y+= CarTwoSpeed.Y;

            Draw();
            // TODO: Add the notion of dying (disable the timer and show a message box or something)
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
