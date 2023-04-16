using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7._04._2023
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        protected void StartRead()
        {
            try
            {
                progressBar1.Value = 0;

                StreamReader sr = new StreamReader(path);

                progressBar1.Maximum = File.ReadLines(path).Count();


                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    progressBar1.PerformStep();
                    textBox2.Text += s;
                    Thread.Sleep(1000);
                }
                    return;
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
            }


           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            path = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartRead();
        }
    }
}
