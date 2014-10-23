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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            Core core = new Core();
            this.Hide();
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
