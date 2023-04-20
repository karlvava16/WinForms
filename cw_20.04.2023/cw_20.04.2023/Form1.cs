using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw_20._04._2023
{
    public partial class Form1 : Form
    {
        Process process;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.Kill();
        }
    }
}
