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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < App.palavrasTotal.Length; i++)
            {
                if (App.palavrasTotal[i] == textBox1.Text.ToLower())
                {
                    MessageBox.Show("Erro, esta palavra ja existe");                  
                }
                
                else
                {
                    for (int j = 0; j < App.palavrasTotal.Length; j++)
                    {
                        if (App.palavrasTotal[j] == null )
                        {
                            App.palavrasTotal[j] += textBox1.Text.ToLower();
                            MessageBox.Show("Sucesso");
                            textBox1.Text = "";
                            break;
                        }                        
                    }
                    break;                      
                }
            }
        }
    }
}
