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
        public Vehicle vehicle1;
        public Vehicle vehicle2;

        int maxspeedX = 3;
        int maxspeedY = 3;

        /// <summary>
        /// De constructor van de game class
        /// </summary>
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

            System.Windows.Forms.Timer decay = new System.Windows.Forms.Timer();
            decay.Interval = 1000;
            decay.Tick += new EventHandler(decay_tick);
            decay.Start();

            vehicle1 = new Vehicle(768,70);
            vehicle2 = new Vehicle(768,118);
            progressBarVehicleOne.Value = 100;
            progressBarVehicleTwo.Value = 100;
        }

        void decay_tick(object sender, EventArgs e)
        {
            try
            {
                if (vehicle1.Speed.X > 0)
                    progressBarVehicleOne.Value = progressBarVehicleOne.Value - vehicle1.Speed.X;
                if (vehicle1.Speed.X < 0)
                    progressBarVehicleOne.Value = progressBarVehicleOne.Value + vehicle1.Speed.X;
                if (vehicle1.Speed.Y > 0)
                    progressBarVehicleOne.Value = progressBarVehicleOne.Value - vehicle1.Speed.Y;
                if (vehicle1.Speed.Y < 0)
                    progressBarVehicleOne.Value = progressBarVehicleOne.Value + vehicle1.Speed.Y;
                if (vehicle2.Speed.X > 0)
                    progressBarVehicleTwo.Value = progressBarVehicleTwo.Value - vehicle2.Speed.X;
                if (vehicle1.Speed.X < 0)
                    progressBarVehicleTwo.Value = progressBarVehicleTwo.Value + vehicle2.Speed.X;
                if (vehicle1.Speed.Y > 0)
                    progressBarVehicleTwo.Value = progressBarVehicleTwo.Value - vehicle2.Speed.Y;
                if (vehicle2.Speed.Y < 0)
                    progressBarVehicleTwo.Value = progressBarVehicleTwo.Value + vehicle2.Speed.Y;
                if (progressBarVehicleOne.Value <= 10)
                    progressBarVehicleOne.Value += 10;
                if (progressBarVehicleTwo.Value <= 10)
                    progressBarVehicleTwo.Value += 10;
            }
            catch (Exception a)
            {
                Console.WriteLine("note enough fuel" + a);
            }
        }

        //Keybinding voor de twee objecten + Snelheid
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && vehicle1.Speed.X >= -maxspeedX)
                vehicle1.Speed.X -= vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Right && vehicle1.Speed.X <= maxspeedX)
                vehicle1.Speed.X += vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Up && vehicle1.Speed.Y >= -maxspeedY)
                vehicle1.Speed.Y -= vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Down && vehicle1.Speed.Y <= maxspeedY)
                vehicle1.Speed.Y += vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.A && vehicle2.Speed.X >= -maxspeedX)
                vehicle2.Speed.X -= vehicle2.AxisSpeed;
            else if (e.KeyCode == Keys.D && vehicle2.Speed.X <= maxspeedX)
                vehicle2.Speed.X += vehicle2.AxisSpeed;
            else if (e.KeyCode == Keys.W && vehicle2.Speed.Y >= -maxspeedY)
                vehicle2.Speed.Y -= vehicle2.AxisSpeed;
            else if (e.KeyCode == Keys.S && vehicle2.Speed.Y <= maxspeedY)
                vehicle2.Speed.Y += vehicle2.AxisSpeed;
            // brandstof balk
            if (progressBarVehicleOne.Value <= 2)
            {
                maxspeedX = 1;
                maxspeedY = 1;
            }
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

        //Tekent de objecten op je juiste locaties
        public void Draw()
        {
            if (Backbuffer != null)
            {
                using (var g = Graphics.FromImage(Backbuffer))
                {
                    g.Clear(Color.Transparent);
                    vehicle1.Draw(g);
                    vehicle2.Draw(g, "red");
                }
                vehicle1.checklocation();
                vehicle2.checklocation();
                //De auto(als in voertuig) debugger! deze controleerd nu op de locatie
                MousePosition.Text = (Convert.ToString(vehicle1.Position));
                //Tegen het kapot gaan van onze game
                vehicle1.getColor();
                vehicle1.getColor();
                Collision();
                Invalidate();
            }
        }
        public void Collision()
        {
            if (vehicle1.Position == vehicle2.Position) vehicle1.Health--; vehicle1.Health--;
        }
    }
}





