using System;
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
    public partial class Form6 : Form
    {
        public static bool kek = false;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (App.admin[0] == textBox1.Text && App.admin[1] == textBox2.Text)
            {
                kek = true;
                MessageBox.Show("Bem vindo","",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                Close();
            }
            else
            {
                MessageBox.Show("Estas não são as credências de admin","",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                kek = false;
            }
        }
    }
}
