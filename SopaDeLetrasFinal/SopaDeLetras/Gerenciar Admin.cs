﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SopaDeLetras
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            App.admin[0] = textBox1.Text;
            App.admin[1] = textBox2.Text;
            MessageBox.Show("Sucesso","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            textBox1.Text = "";
            textBox2.Text = "";
            Close();
        }
    }
}
