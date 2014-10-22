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
    class Vehicle
    {
        public int Health{get; set;}
        public int Maxspeed{get; set;}
        public int Accl{get; set;}
        public int Fuel{get; set;}
        public int Ballsize{get; set;}
        
        public Point BallPos{get; set;}
        public Point BallSpeed {get; set;}

        public int BallAxisSpeed {get; set;}
        
        /// <summary>
        /// De contructor van Vehicle
        /// </summary>
        /// <param name="value">De snelheid van het voertuig</param>
        public Vehicle(int value)
        {
            this.BallAxisSpeed = 2;
            this.BallPos = new Point(40,40);
            this.BallSpeed = new Point(value, value);
            this.Ballsize = 50;
        }


        
        
        
        
        
        ///??????
        /*public void Ballposition(int change);

        

        Point BallPos = new Point(30, 30);
        Point BallSpeed = new Point(BallAxisSpeed, BallAxisSpeed);
        const int BallSize = 50;*/

    }
}

