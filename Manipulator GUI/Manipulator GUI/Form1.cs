﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("W");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("I");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("K");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("J");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }
    }
}
