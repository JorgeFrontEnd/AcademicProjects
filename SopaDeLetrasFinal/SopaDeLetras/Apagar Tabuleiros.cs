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
    public partial class Form8 : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {                    
                    App.bt[i, j].Text = "";
                }
            }
        }
        public Form8()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
            
        private void ApagarLetras_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < App.n_tabuleiros; i++)
            {                
                if (App.data3[i, 1, 1] == null)
                {
                    break;
                }
                comboBox1.Items.Add("Tabuleiro-" + i);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.Items != null) {
                listBox1.Items.Clear();
                }
            
                for (int i = 0; i < 19; i++)
                {
                    if (App.tabuleiroPalavras[comboBox1.SelectedIndex, i] != null)
                    {
                        listBox1.Items.Add(App.tabuleiroPalavras[comboBox1.SelectedIndex, i]);                        
                    }
                }
                
                for (int i = 0; i < 15; i++)
                    {
                    for(int j = 0; j < 15; j++)
                    {
                        App.bt[i, j].Text = App.data3[comboBox1.SelectedIndex,i,j];
                    }
                }                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    App.data3[comboBox1.SelectedIndex,i,j] = "";                    
                    App.bt[i, j].Text = "";
                    
                }       
            }
            for (int i = 0; i < 15; i++)
            {
                App.tabuleiroPalavras[comboBox1.SelectedIndex,i] = "";                
            }
                listBox1.Items.Clear();
        }            
    }
}
