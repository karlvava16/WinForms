﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class BestOil : Form
    {
        Form2 gasStation;
        Form3 caffe;
        public BestOil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gasStation = new Form2();
            DialogResult result = gasStation.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caffe = new Form3();
            DialogResult result = caffe.ShowDialog();

        }

        private void BestOil_Load(object sender, EventArgs e)
        {

        }
    }
}
