using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Racegame
{
    public class Vehicle
    {
        //Getters en Setters
        public Point Position;
        public Point Speed;
        public Point Spawn;
        public int CarSize { get; set; }
        public int AxisSpeed { get; set; }
        public Color kleur { get; set; }
        public int Health { get; set; }
        public int Fuel { get; set; }
        public int Laps { get; set; }
        public Boolean gras { get; set; }
        public Boolean CheckpointOne { get; set; }
        public Boolean CheckpointTwo { get; set; }
        public Bitmap image;
        /// <summary>
        /// De constructor
        /// </summary>
        /// <param name="value">De locatie van de vehicle</param>
        public Vehicle(int x, int y)
        {
            this.Position = new Point(x, y);
            this.Spawn = new Point(x, y);
            this.Speed = new Point(0, 0);
            this.CarSize = 30;
            this.AxisSpeed = 1;
            this.Health = 300;
            this.Fuel = 100;
            this.Laps = 1;
            //Checkt de kleur waar vehicle op positie staat
            image = new Bitmap(Racegame.Properties.Resources.map);
        }
        /// <summary>
        /// Tekent het object op de juiste locatie
        /// </summary>
        /// <param name="g">Het type</param>
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
        }
        /// <summary>
        /// Overload van de eerdere methode
        /// </summary>
        /// <param name="g">Het type</param>
        /// <param name="b">De kleur in string</param>
        public void Draw(Graphics g, String b)
        {
            if (b == "red")
                g.FillRectangle(Brushes.Red, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
            if (b == "yellow")
                g.FillRectangle(Brushes.Yellow, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
        }
        public void checklocation()
        {
            //Hier word gecheckt of het voertuig zich mag verplaatsen op de locatie
            if (Position.X > 0 & Position.Y > 0 & Position.X < 1200 & Position.Y < 900)
            {

                Position.X += Speed.X;
                Position.Y += Speed.Y;
            }
            else
            {
                respawn();
            }
        }
        public void getColor()
        {
            try
            {          
                //Een if statement voor een onnodige exception
                if (Position.X < -10 | Position.Y < -10 | Position.X < 1200 | Position.Y < 700)
                {
                    //wat is de kleur van de huidige positie
                    Color kleur = image.GetPixel(Position.X, Position.Y);
                    //Debug geeft de code waar hij op staat
                    //Console.WriteLine(kleur);
                    //Controleer de juist locatie
                    //Gras
                    if (kleur.A.Equals(255) && kleur.R.Equals(0) && kleur.G.Equals(128) && kleur.B.Equals(1))
                    {
                        Console.WriteLine("Gras");
                        gras = true;
                    }

                    //De weg
                    else if (kleur.A.Equals(255) && kleur.R.Equals(106) && kleur.G.Equals(104) && kleur.B.Equals(105))
                    {
                        Console.WriteLine("weg");
                        gras = false;
                    }
                    //Pitstop
                    else if (kleur.A.Equals(255) && kleur.R.Equals(0) && kleur.G.Equals(0) && kleur.B.Equals(206))
                    {
                        Console.WriteLine("Pitstop");

                        gras = false;

                        this.Health += Game.tanken();

                        if (Fuel < 100)
                            this.Fuel += Game.tanken();
                        if (Health < 300)
                            this.Health += Game.tanken();
                    }
                    //Rood
                    else if (kleur.A.Equals(255) && kleur.R.Equals(234) && kleur.G.Equals(31) && kleur.B.Equals(37))
                    {
                        Console.WriteLine("Dood");
                        respawn();
                    }
                    //Finish
                    else if (kleur.A.Equals(255) && kleur.R.Equals(0) && kleur.G.Equals(0) && kleur.B.Equals(0))
                    {
                        Console.WriteLine("Finish");
                        if(CheckpointOne == true && CheckpointTwo == true)
                        {
                            lap_count();
                            CheckpointOne = false;
                            CheckpointTwo = false;
                        }
                    }
                    //Checkpoint een
                    else if (kleur.A.Equals(255) && kleur.R.Equals(151) && kleur.G.Equals(135) && kleur.B.Equals(102))
                    {
                        Console.WriteLine("CheckPoint1");
                        CheckpointOne = true;
                    }
                    //Checkpoint twee
                    else if (kleur.A.Equals(255) && kleur.R.Equals(208) && 	kleur.G.Equals(142) && kleur.B.Equals(94))
                    {
                        if(CheckpointOne == true)
                        {
                            Console.WriteLine("checkpoint2");
                            CheckpointTwo = true;
                        }
                    }   
                    else
                    {
                        gras = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error met de bitmap: " + e);
                respawn();
            }
        }
        public void checkHealth()
        {
            if (Health <= 0) 
                respawn();
        }
        public void respawn()
        {
            Health = 300;
            Fuel = 100;
            Speed.X = 0;
            Speed.Y = 0;
            CheckpointOne = false;
            CheckpointTwo = false;
            Position = Spawn;
        }
        public void lap_count()
        {
            this.Laps++;
        }
    }
}
