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
            First_Task();
            #endregion
            #region Second_Task
            Second_Task();
            #endregion

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

        }

        public void First_Task()
        {
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
            {
                this.Close();
            }
            else if (e.Button == MouseButtons.Left)
            {
                if ((e.X < 10 || e.X > Size.Width - 10) && (e.Y < 10 || e.Y > Size.Height - 10))
                {
                    MessageBox.Show("You click out of rectangle");

                }
                else if ((e.X > 10 && e.X < Size.Width - 10) && (e.Y > 10 && e.Y < Size.Height - 10))
                {
                    MessageBox.Show("You click in rectangle");
                }
                else
                {
                    MessageBox.Show("You click right on rectangle");

                }
            }
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = String.Format("x = {0}  y = {1}", e.X, e.Y);
        }
    }
}
