using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_20._04._2023
{
    public partial class Form1 : Form
    {
        Process[] processes;

        public Form1()
        {
            InitializeComponent();
            RefreshList();
        }

        void RefreshList()
        {

            processes = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process process in processes)
            {
                listBox1.Items.Add($"{process.ProcessName}\t\t\t\t{process.Id}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(listBox1.SelectedItem.ToString(), @"(\w+\t\t\t\t)(\d+)");
            MessageBox.Show(match.Groups[2].Value);

            foreach (var process in processes)
            {
                if (process.Id == Convert.ToInt32(match.Groups[2].Value))
                {
                    process.Kill();
                    break;
                }
            }
            RefreshList();

        }
    }
}
