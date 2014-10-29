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
            //Stelt de snelheid in, in nanosecondes
            GameTimer.Interval = 10;
            GameTimer.Tick += new EventHandler(GameTimer_Tick);//Moet je locatie functie zoeken
            GameTimer.Start();
            game.Show();
        }
        void GameTimer_Tick(object sender, EventArgs e)
        {
            game.Draw();
            if (game.won() == true)
            {
                GameTimer.Stop();

                int player1 = game.getStatusVehicle1();
                int player2 = game.getStatusVehicle2();
                if (player1 > player2) MessageBox.Show("Match is over Player one: " + player1 + "  Player two: " + player2 + "Player One won");
                if (player1 < player2) MessageBox.Show("Match is over Player one: " + player1 + "  Player two: " + player2 + "Player Two won");
            }

        }
    }
}
