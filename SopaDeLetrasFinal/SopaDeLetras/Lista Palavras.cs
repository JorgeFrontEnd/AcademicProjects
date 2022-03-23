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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < App.palavrasTotal.Length; i++)
            {
                if (App.palavrasTotal[i] != null) {
                    listBox1.Items.Add(App.palavrasTotal[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
