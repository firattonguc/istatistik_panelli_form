﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStokUygulama
{
    public partial class Frmanaform : Form
    {
        public Frmanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmurun fr=new frmurun();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmistatistik fr=new frmistatistik();
            fr.Show();
        }
    }
}
