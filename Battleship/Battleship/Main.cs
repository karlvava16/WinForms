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
    public partial class Main : Form
    {
        BattleField firstPlayer;
        BattleField secondPlayer;
        public Main()
        {
            InitializeComponent();

            
            // creating battle fields
            firstPlayer = new BattleField(new Point(0,60), 0, new Size(50,50));
            secondPlayer = new BattleField(new Point(this.Size.Width - 516, 60), 0, new Size(50, 50));

            // add battle fields in controls

            foreach (var field in firstPlayer.Fields)
            {
                Controls.Add(field);
            }

            foreach (var field in secondPlayer.Fields)
            {
                Controls.Add(field);
            }
        }

        
    }
}
