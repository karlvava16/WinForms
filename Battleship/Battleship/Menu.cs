using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Menu : Form
    {
        Main main;
        public Menu()
        {
            InitializeComponent();
        }

        private void SingleplayerButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            main = new Main();
            DialogResult rez = main.ShowDialog();
            Visible = true;
        }

    }
}
