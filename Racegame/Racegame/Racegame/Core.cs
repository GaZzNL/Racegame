using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racegame
{
    class Core
    {
        private Timer GameTimer;
        Game game = new Game();

        //Contructor van de Core
        public Core()
        {
            GameTimer = new Timer();
            //Zet de steld de snelheid in, in nanosecondes
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(game.GameTimer_Tick);//Moet je locatie functie zoeken
            GameTimer.Start();
            game.Show();
        }
    }
}
