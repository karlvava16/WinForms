using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            #region First_Task
            int length = 0;
            string[] CW = { 
                "Name: Vladislav\n",
                "Surname:Karlinskyi\n",
                "Date of birth: 23th January 2004\n",
                "Programm languages: C++, C#, Python\n" 
            };
            foreach (string c in CW)
            {
                length += c.Length;
                MessageBox.Show(c);
            }

            MessageBox.Show((length / CW.Length).ToString() + "is average characters in message");
            #endregion
            #region Second_Task
            Second_Task();
            #endregion

            InitializeComponent();
        }

        public void Second_Task()
        {
            Random rand = new Random();
            int number = 0;
            int count = 0;
            DialogResult result = DialogResult.OK;
            while (true)
            {
                number = 0;
                count = 0;
                result = DialogResult.OK;
                MessageBox.Show("Think of number between 1 and 2000");

                do
                {
                    count++;
                    number = rand.Next(1, 2000);
                    result = MessageBox.Show($"Is it {number}?", $"Attempt number {count}", MessageBoxButtons.YesNo);

                } while (result != DialogResult.Yes);

                result = MessageBox.Show($"Number: {number}\tAttempts: {count}\nTry once more?",
                    "Try once more?", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    break;
            }
        }
    }
}
