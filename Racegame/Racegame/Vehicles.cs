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
        int Health;
        int Maxspeed;
        int Accl;
        int Fuel;

        public void Ballposition(int change);

        const int BallAxisSpeed = 2;

        Point BallPos = new Point(30, 30);
        Point BallSpeed = new Point(BallAxisSpeed, BallAxisSpeed);
        const int BallSize = 50;

    }
}

