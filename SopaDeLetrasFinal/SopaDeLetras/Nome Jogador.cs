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
    public partial class Form3 : Form
    {
        
        public static String nome;
        public Form3()
        {
            InitializeComponent();          
       }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Erro.Digite o seu nome para proseguir", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nome = textBox1.Text;
                Jogador J = new Jogador(nome, "00:00:00");
                App.jogadores.Add(J);
                MessageBox.Show("Bem vindo " + nome, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                Close();
            }                  
        }
    }
}
