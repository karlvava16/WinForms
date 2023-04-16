using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestOil
{
    public partial class Form2 : Form
    {
        protected double value;
        protected Regex reg = new Regex("^(\\d{1,3}(,\\d{3})*|(\\d+))(\\.\\d{0,2})?$");

        SortedList<string, double> fuel = new SortedList<string, double>();

        public Form2()
        {
            InitializeComponent();
            fuel.Add("[ВИБРАТИ]", 0);
            fuel.Add("A-95", 49.43);
            fuel.Add("A-92", 47.83);
            fuel.Add("Дизиль", 53.95);
            fuel.Add("Газ", 25.72);

            

            foreach (string key in fuel.Keys)
                listBox1.Items.Add(key);
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuel.TryGetValue((string)listBox1.Items[listBox1.SelectedIndex], out value);
            textBox1.Text = value.ToString();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                if (!reg.IsMatch(textBox2.Text))
                {
                    textBox2.Text = textBox2.Text.ToString().Substring(0, textBox2.Text.Length - 1);
                    textBox2.SelectionStart = textBox2.Text.Length;

                }
                if (textBox2.Text.Length != 0)
                {
                    textBox4.Text = textBox3.Text = (Convert.ToDouble(textBox1.Text.ToString()) * Convert.ToDouble(textBox2.Text.ToString())).ToString();
                }
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
            {
                if (!reg.IsMatch(textBox3.Text))
                {
                    textBox3.Text = textBox3.Text.ToString().Substring(0, textBox3.Text.Length - 1);
                    textBox3.SelectionStart = textBox3.Text.Length;
                }
                if (textBox3.Text.Length != 0)
                {
                    textBox4.Text = textBox3.Text;
                    textBox2.Text = (Convert.ToDouble(textBox3.Text.ToString()) /
                       Convert.ToDouble(textBox1.Text.ToString())).ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox2.Text.Length == 0)
                {
                    textBox4.Text = textBox3.Text = "0.00";
                }
                else
                {
                    textBox4.Text = textBox3.Text = (Convert.ToDouble(textBox1.Text.ToString()) *
                        Convert.ToDouble(textBox2.Text.ToString())).ToString();
                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox3.Text.Length == 0)
                {
                    textBox2.Text = textBox4.Text = "0.00";
                }
                else
                {
                    textBox4.Text = textBox3.Text;
                    if (Convert.ToDouble(textBox1.Text.ToString()) != 0.0)
                        textBox2.Text = (Convert.ToDouble(textBox3.Text.ToString()) / Convert.ToDouble(textBox1.Text.ToString())).ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = false;
        }
    }
}
