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
    class Core
    {
        private Timer GameTimer;


        //Contructor van de Core
        public Core()
        {
            GameTimer = new Timer();
            //Zet de steld de snelheid in, in nanosecondes
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);//Moet je locatie functie zoeken
            GameTimer.Start();
        }
        public void GameTimer_Tick(object sender, EventArgs e)
        {
            BallPos.X += BallSpeed.X;
            BallPos.Y += BallSpeed.Y;


            Game.Draw();

            // TODO: Add the notion of dying (disable the timer and show a message box or something)
        }
    }
}
