﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace Projct_plc
{
    public partial class Form1 : Form
    {
        MyParser p;
        public Form1()
        {
            InitializeComponent();
            p = new MyParser("project.cgt",listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            p.Parse(textBox1.Text);
        }
    }
}
