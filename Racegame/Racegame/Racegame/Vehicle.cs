using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Racegame
{
    class Vehicle
    {
        //Getters en Setters
        public Point Position { get; set; }
        public Point Speed { get; set; }
        public int CarSize { get; set; }
        public int AxisSpeed { get; set; }

        /// <summary>
        /// De constructor
        /// </summary>
        /// <param name="value">De locatie van de vehicle</param>
        public Vehicle(int value)
        {
            this.Position = new Point(value, value);
            this.Speed = new Point(value, value);
            this.CarSize = 30;
            this.AxisSpeed = 2;
        }
    }
}
