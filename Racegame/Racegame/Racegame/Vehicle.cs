﻿using System;
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
        public int CarSize { get; set; }
        public int AxisSpeed { get; set; }

        /// <summary>
        /// De constructor
        /// </summary>
        /// <param name="value">De locatie van de vehicle</param>
        public Vehicle(int value)
        {
            this.Position = new Point(value, value);
            this.Speed = new Point(0, 0);
            this.CarSize = 30;
            this.AxisSpeed = 2;
        }
        /// <summary>
        /// Tekent het object op de juiste locatie
        /// </summary>
        /// <param name="g">De type</param>
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
        }
        /// <summary>
        /// Overload van het eerdere methode
        /// </summary>
        /// <param name="g">De type</param>
        /// <param name="b">De kleur in string</param>
        public void Draw(Graphics g, String b)
        {
            if (b == "red")
                g.FillEllipse(Brushes.Red, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
            if (b == "yellow")
                g.FillEllipse(Brushes.Yellow, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
        }
    }
}
