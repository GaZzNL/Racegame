using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racegame
{
    class Core
    {
        private System.Windows.Forms.Timer GameTimer;
        Game game = new Game();

        //Contructor van de Core
        public Core()
        {
            GameTimer = new System.Windows.Forms.Timer();
            //Zet de steld de snelheid in, in nanosecondes
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(game.GameTimer_Tick);//
            GameTimer.Start();
            game.Show();
        }
    }
}
