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

            vehicle1 = new Vehicle(745, 75, "red");
            vehicle2 = new Vehicle(25, 125, "blue");

            Controls.Add(vehicle1.picBox);
            Controls.Add(vehicle2.picBox);        
        }

        //Keybinding voor de twee objecten + Snelheid
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                vehicle1.Speed.X -= vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Right)
                vehicle1.Speed.X += vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Up)
                vehicle1.Speed.Y -= vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.Down)
                vehicle1.Speed.Y += vehicle1.AxisSpeed;
            else if (e.KeyCode == Keys.A)
                vehicle2.Speed.X -= vehicle2.AxisSpeed;
            else if (e.KeyCode == Keys.D)
                vehicle2.Speed.X += vehicle2.AxisSpeed;
            else if (e.KeyCode == Keys.W)
                vehicle2.Speed.Y -= vehicle2.AxisSpeed;
            else if (e.KeyCode == Keys.S)
                vehicle2.Speed.Y += vehicle2.AxisSpeed;
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

                vehicle1.picBox.Location = new Point(
                    +vehicle1.Speed.X,
                    +vehicle1.Speed.Y
                );
                vehicle2.picBox.Location = new Point(
                    +vehicle2.Speed.X,
                    +vehicle2.Speed.Y
                );
                Invalidate();
            } 
        }
    }
}

        
   

        
          