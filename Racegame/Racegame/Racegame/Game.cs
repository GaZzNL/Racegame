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

            vehicle1 = new Vehicle(768,70);
            vehicle2 = new Vehicle(768,118);
            progressBarVehicleOne.Value = 100;
        }

        void decay_tick(object sender, EventArgs e)
        {
            progressBarVehicleOne.Value = progressBarVehicleOne.Value - 1;
            if (progressBarVehicleOne.Value <= 2)
            {

                progressBarVehicleOne.Value = progressBarVehicleOne.Value + 10;

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
                //hier check je of de autos niet van het scherm rijden/ Als de voertuig "Te verweg is van de baan" word hij op de start positie gezet
                if (vehicle1.Position.X < -10 | vehicle1.Position.Y < -10 | vehicle1.Position.X > 1000 | vehicle1.Position.Y > 710)
                {
                    vehicle1.Position.X = 768;
                    vehicle1.Position.Y = 70;
                }
                //Zelfde geld voor voertuig2
                if (vehicle2.Position.X < -10 | vehicle2.Position.Y < -10 | vehicle2.Position.X > 1000 | vehicle2.Position.Y > 710)
                {
                    vehicle2.Position.X = 768;
                    vehicle2.Position.Y = 70;
                }
                //Hier word gecheckt als de voertuig zich mag verplaatsen op de locatie
                if (vehicle2.Position.X < 0 & vehicle2.Position.Y < 0)
                {
                    vehicle2.Position.X = 758;
                    vehicle2.Position.Y = 70;
                }
                //Hier word gecheckt als de voertuig zich mag verplaatsen op de locatie
                if (vehicle1.Position.X > 0 & vehicle1.Position.Y > 0 & vehicle1.Position.X < 990 & vehicle1.Position.Y < 700)
                {
                    vehicle1.Position.X += vehicle1.Speed.X;
                    vehicle1.Position.Y += vehicle1.Speed.Y;
                }
                //Als de voertuig tegen de grens aanzit word hij gestopt
                else
                {
                    vehicle1.Position.X -= vehicle1.Speed.X;
                    vehicle1.Position.Y -= vehicle1.Speed.Y;
                }
                //Hier word gecheckt als de voertuig zich mag verplaatsen op de locatie
                if (vehicle2.Position.X > 0 & vehicle2.Position.Y > 0 & vehicle2.Position.X < 990 & vehicle2.Position.Y < 700)
                {
                    vehicle2.Position.X += vehicle2.Speed.X;
                    vehicle2.Position.Y += vehicle2.Speed.Y;
                }
                //Als de voertuig tegen de grens aanzit word hij gestopt
                else
                {
                    vehicle2.Position.X -= vehicle2.Speed.X;
                    vehicle2.Position.Y -= vehicle2.Speed.Y;
                }
                //De auto(als in voertuig) debugger! deze controleerd nu op de locatie
                MousePosition.Text = (Convert.ToString(vehicle1.Position));
                //Tegen het kapot gaan van onze game
                try
                {
                    //wat is de kleur van de huidige positie
                    //Checkt de kleur waar vehicle1 op positie staat(We moeten echt de GUI afschafen van Visual studio :p)
                    //Controleer de juist locatie
                    var image = new Bitmap(@"C:\Users\robert\Documents\GitHub\Racegame\Racegame\Racegame\Racegame\Resources\Naamloos.jpg");
                    //Een if statement voor een onnodige exception
                    if (vehicle1.Position.X < -10 | vehicle1.Position.Y < -10 | vehicle1.Position.X < 1000 | vehicle1.Position.Y < 710)
                    {
                        Color kleur = image.GetPixel(vehicle1.Position.X, vehicle1.Position.Y);
                        //Debug geeft de code waar hij op staat
                        Console.WriteLine(kleur);
                        //Gras
                        if (kleur.A.Equals(255) && kleur.R.Equals(0) && kleur.G.Equals(128) && kleur.B.Equals(1))
                            Console.WriteLine("Gras");
                        //De weg
                        if (kleur.A.Equals(255) && kleur.R.Equals(106) && kleur.G.Equals(104) && kleur.B.Equals(105))
                            Console.WriteLine("weg");
                        //Pitstop
                        if (kleur.A.Equals(255) && kleur.R.Equals(0) && kleur.G.Equals(0) && kleur.B.Equals(206)) 
                            Console.WriteLine("Pitstop");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error met de bitmap: " + e);
                }
            
                Invalidate();
            }
        }
    }
}





