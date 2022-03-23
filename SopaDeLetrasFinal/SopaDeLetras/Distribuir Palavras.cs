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
    public partial class Form2 : Form
    {
        public static String[] s_pais;
        public static int func,countpalavras=0, i_pais = 0;
        public static int[,] localizacaopalavras;

        public Form2()
        {
            s_pais = new string[19];
            localizacaopalavras = new int[19, 4];
            InitializeComponent();

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < App.palavrasTotal.Length; i++)
            {
                if (App.palavrasTotal[i] != null)
                   comboBox1.Items.Add(App.palavrasTotal[i]);
            }
        }
                                            /***************************************     
                                             ****funções para escrever palavras*****
                                             *************************************** 
                                             */
        private void horizontal_esqerda(int c, int l, char[] p_letas)//
        {
            bool letras = true; // to validate if letras can be in the space
            try
            {
                for (int i = 0; i < s_pais[i_pais].Length; i++)
                {
                    if (App.bt[c + i, l].Text == p_letas[i].ToString() || App.bt[c + i, l].Text == "")
                    {

                    }
                    else
                    {
                        letras = false;
                        MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (letras)
                {
                    for (int i = 0; i < s_pais[i_pais].Length; i++)
                    {
                        App.bt[c + i, l].Text = p_letas[i].ToString();
                    }
                    App.novapalavra[countpalavras] = comboBox1.SelectedItem.ToString();
                    countpalavras++;
                    limparpalavra();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void horizontal_direita(int c, int l, char[] p_letas)
        {
            bool letras = true; // to validate if letras can be in the space
            try
            {
                for (int i = 0; i < s_pais[i_pais].Length; i++)
                {
                    if (App.bt[c - i, l].Text == p_letas[i].ToString() || App.bt[c - i, l].Text == "")
                    {

                    }
                    else
                    {
                        letras = false;
                        MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (letras)
                {
                    for (int i = 0; i < s_pais[i_pais].Length; i++)
                    {
                        App.bt[c - i, l].Text = p_letas[i].ToString();
                    }
                    App.novapalavra[countpalavras] = comboBox1.SelectedItem.ToString();
                    countpalavras++;
                    limparpalavra();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


        }
        private void vertical_baixo(int c, int l, char[] p_letas)
        {
            bool letras = true; // to validate if letras can be in the space
            try
            {
                for (int i = 0; i < s_pais[i_pais].Length; i++)
                {
                    if (App.bt[c, l + i].Text == p_letas[i].ToString() || App.bt[c, l + i].Text == "")
                    {

                    }
                    else
                    {
                        letras = false;
                        MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        break;
                    }
                }
                if (letras)
                {
                    for (int i = 0; i < s_pais[i_pais].Length; i++)
                    {
                        App.bt[c, l + i].Text = p_letas[i].ToString();
                    }
                    App.novapalavra[countpalavras] = comboBox1.SelectedItem.ToString();
                    countpalavras++;
                    limparpalavra();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }


        }
        private void vertical_cima(int c, int l, char[] p_letas)
        {
            bool letras = true; // to validate if letras can be in the space
            try
            {
                for (int i = 0; i < s_pais[i_pais].Length; i++)
                {
                    if (App.bt[c, l - i].Text == p_letas[i].ToString() || App.bt[c, l - i].Text == "")
                    {

                    }
                    else
                    {
                        letras = false;
                        MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        break;
                    }
                }
                if (letras)
                {
                    for (int i = 0; i < s_pais[i_pais].Length; i++)
                    {
                        App.bt[c, l - i].Text = p_letas[i].ToString();
                    }
                    App.novapalavra[countpalavras] = comboBox1.SelectedItem.ToString();
                    countpalavras++;
                    limparpalavra();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }


        }
        private void obliqua_esquerda(int c, int l, char[] p_letas)
        {
            bool letras = true; // to validate if letras can be in the space
            try
            {
                for (int i = 0; i < s_pais[i_pais].Length; i++)
                {
                    if (App.bt[c + i, l + i].Text == p_letas[i].ToString() || App.bt[c + i, l + i].Text == "")
                    {

                    }
                    else
                    {
                        letras = false;
                        MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        break;
                    }
                }
                if (letras)
                {
                    for (int i = 0; i < s_pais[i_pais].Length; i++)
                    {
                        App.bt[c + i, l + i].Text = p_letas[i].ToString();
                    }
                    App.novapalavra[countpalavras] = comboBox1.SelectedItem.ToString();
                    countpalavras++;
                    limparpalavra();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void obliqua_direita(int c, int l, char[] p_letas)
        {
            bool letras = true; // to validate if letras can be in the space
            try
            {
                for (int i = 0; i < s_pais[i_pais].Length; i++)
                {
                    if (App.bt[c + i, l - i].Text == p_letas[i].ToString() || App.bt[c + i, l - i].Text == "")
                    {

                    }
                    else
                    {
                        letras = false;
                        MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (letras)
                {
                    for (int i = 0; i < s_pais[i_pais].Length; i++)
                    {
                        App.bt[c + i, l - i].Text = p_letas[i].ToString();
                    }
                    App.novapalavra[countpalavras] = comboBox1.SelectedItem.ToString();
                    countpalavras++;
                    limparpalavra();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //______________________________________________________fim__________________________________________________________________
                                            /***************************************     
                                             ****funções para apagar palavras *****
                                             *************************************** 
                                             */
        private void apagar_horizontal_esqerda()
        {
            try
            {
                for (int i = 0; i < localizacaopalavras[i_pais, 0]; i++)
                    App.bt[localizacaopalavras[i_pais, 1] + i, localizacaopalavras[i_pais, 2]].Text = "";

                countpalavras--;
                comboBox1.Items.Add(App.novapalavra[countpalavras]);   
            }
            catch (Exception)
            { MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ; i_pais++; }
        }
        private void apagar_horizontal_direita()
        {
            try
            {
                for (int i = 0; i < localizacaopalavras[i_pais, 0]; i++)
                    App.bt[localizacaopalavras[i_pais, 1] - i, localizacaopalavras[i_pais, 2]].Text = "";

                countpalavras--;
                comboBox1.Items.Add(App.novapalavra[countpalavras]);
            }
            catch (Exception)
            { MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ; i_pais++; }
        }
        private void apagar_vertical_baixo()
        {
            try
            {
                for (int i = 0; i < localizacaopalavras[i_pais, 0]; i++)
                    App.bt[localizacaopalavras[i_pais, 1], localizacaopalavras[i_pais, 2] + i].Text = "";

                countpalavras--;
                comboBox1.Items.Add(App.novapalavra[countpalavras]);
            }
            catch (Exception) { MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ; i_pais++; }
        }
        private void apagar_vertical_cima()
        {
            try
            {
                for (int i = 0; i < localizacaopalavras[i_pais, 0]; i++)
                    App.bt[localizacaopalavras[i_pais, 1], localizacaopalavras[i_pais, 2] - i].Text = "";

                countpalavras--;
                comboBox1.Items.Add(App.novapalavra[countpalavras]);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                i_pais++;
            }
        }
        private void apagar_obliqua_esquerda()
        {
            try
            {
                for (int i = 0; i < localizacaopalavras[i_pais, 0]; i++)
                    App.bt[localizacaopalavras[i_pais, 1] + i, localizacaopalavras[i_pais, 2] + i].Text = "";

                countpalavras--;
                comboBox1.Items.Add(App.novapalavra[countpalavras]);
            }
            catch (Exception)
            { MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ; i_pais++; }
        }
        private void apagar_obliqua_direita()
        {
            try
            {
                for (int i = 0; i < localizacaopalavras[i_pais, 0]; i++)
                    App.bt[localizacaopalavras[i_pais, 1] + i, localizacaopalavras[i_pais, 2] - i].Text = "";

                countpalavras--;
                comboBox1.Items.Add(App.novapalavra[countpalavras]);
            }
            catch (Exception)
            { MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error); ; i_pais++; }

        }

        //___________________________________________________fim__________________________________________________________
        private void limparpalavra()
        {
            comboBox1.Items.Remove(s_pais[i_pais]);
            localizacaopalavras[i_pais, 0] = Convert.ToInt32(textBox3.Text);//dim
            localizacaopalavras[i_pais, 1] = Convert.ToInt32(textBox2.Text);//coluna
            localizacaopalavras[i_pais, 2] = Convert.ToInt32(textBox1.Text);//linha
            localizacaopalavras[i_pais, 3] = func;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            i_pais++;
            func = 0;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "" && textBox1.Text != "" && s_pais[i_pais] != null)
            {
                int c;
                int l;
                c = Convert.ToInt32(textBox2.Text);
                l = Convert.ToInt32(textBox1.Text);
                // MessageBox.Show(c.ToString()+l.ToString());
                char[] p_letas = s_pais[i_pais].ToCharArray();

                if (radioButton8.Checked)
                {
                    String reverse = "";
                    for (int i = p_letas.Length - 1; i > -1; i--)
                    {
                        reverse += p_letas[i];
                    }
                    p_letas = reverse.ToCharArray();
                }
                if (radioButton1.Checked)
                {
                    func = 1;
                    horizontal_esqerda(c, l, p_letas);

                }
                else if (radioButton2.Checked)
                {
                    func = 2;
                    horizontal_direita(c, l, p_letas);
                }
                else if (radioButton3.Checked)
                {
                    func = 3;
                    vertical_baixo(c, l, p_letas);
                }
                else if (radioButton4.Checked)
                {
                    func = 4;
                    vertical_cima(c, l, p_letas);
                }
                else if (radioButton5.Checked)
                {
                    func = 5;
                    obliqua_esquerda(c, l, p_letas);
                }
                else if (radioButton6.Checked)
                {
                    func = 6;
                    obliqua_direita(c, l, p_letas);
                }

            }
            else
            {
                MessageBox.Show("Erro");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i_pais--;
            switch (localizacaopalavras[i_pais, 3])
            {
                case 1:
                    apagar_horizontal_esqerda();
                    break;
                case 2:
                    apagar_horizontal_direita();
                    break;
                case 3:
                    apagar_vertical_baixo();
                    break;
                case 4:
                    apagar_vertical_cima();
                    break;
                case 5:
                    apagar_obliqua_esquerda();
                    break;
                case 6:
                    apagar_obliqua_direita();
                    break;
                default:
                    MessageBox.Show("Erro");
                    i_pais++;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int x;
            s_pais[i_pais] = comboBox1.SelectedItem.ToString();
            x = s_pais[i_pais].Length;
            textBox3.Text = x.ToString();
        }
    }
}

