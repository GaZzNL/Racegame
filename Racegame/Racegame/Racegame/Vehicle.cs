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
        public int CarSize { get; set; }
        public int AxisSpeed { get; set; }
        public PictureBox picBox { get; set; }

        /// <summary>
        /// De constructor
        /// </summary>
        /// <param name="value">De locatie van de vehicle</param>
        public Vehicle(int value, int value2, String k)
        {
            this.picBox = new PictureBox();
            this.picBox.Size = new Size(30, 30);
            this.picBox.Location = new Point(value, value2);
            picBox.BackColor = Color.FromName("k");

            this.AxisSpeed = 2;
        }
        /// <summary>
        /// Tekent het object op de juiste locatie
        /// </summary>
        /// <param name="g">De type</param>
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, this.Position.X - this.CarSize / 2, this.Position.Y - this.CarSize / 2, this.CarSize, this.CarSize);
        }
   }
}

