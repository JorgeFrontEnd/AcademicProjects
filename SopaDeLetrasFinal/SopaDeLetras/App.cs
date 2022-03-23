/**
 * Jorge Ramalhete
 * Fabio Duarte
 * UFCD 5412
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace SopaDeLetras
{

    public partial class App : Form
    {
        public static List<Jogador> jogadores = new List<Jogador>();
        public static String[] admin = { "admin", "admin" };
        public static String[] palavrasTotal = new String[100];
        public static int n_tabuleiros = 100;
        static int count = 0;
        public static int count_color = 0;
        int[] n = new int[2];
        String palavra;
        public String tempo;
        int[,] lockpalavras = new int[113, 2];
        Thread t1;
        static System.Timers.Timer t;
        int i, j, k;
        int random;
        int indexTabuleiro;
        public static Button[,] bt = new Button[15, 15];
        CheckBox[] chc = new CheckBox[19];
        Label[] lb = new Label[19];
        //Variaveis relativas Forms       
        Form3 nomeJogador = new Form3();
        Form4 ListaPalavras = new Form4();
        Form5 AdicionarPalavras = new Form5();
        Form6 AdminLogin = new Form6();
        Form7 AdmimGerir = new Form7();


        public static String[,] TabuleiroJogo = new String[15, 15];
        String[,] data0 =
        {
            {"d", "u", "b", "a", "i", "k", "w", "z", "p", "e", "q", "u", "i", "n", "s"},
            {"a", "l", "x", "h", "j", "l", "c", "p", "o", "r", "t", "o", "d", "v", "l"},
            {"s", "i", "n", "g", "a", "p", "u", "r", "a", "p", "p", "r", "a", "g", "a"},
            {"x", "s", "f", "b", "n", "u", "s", "z", "a", "m", "c", "x", "k", "r", "e"},
            {"c", "b", "a", "m", "e", "s", "t", "e", "r", "d", "a", "m", "y", "o", "p"},
            {"z", "o", "m", "x", "c", "z", "w", "q", "g", "f", "h", "m", "j", "o", "i"},
            {"q", "a", "g", "a", "j", "x", "t", "o", "q", "u", "i", "o", "x", "z", "a"},
            {"s", "e", "u", "l", "k", "a", "a", "a", "s", "z", "a", "k", "a", "h", "d"},
            {"o", "r", "h", "a", "p", "n", "y", "l", "h", "f", "z", "s", "m", "r", "e"},
            {"a", "o", "g", "v", "f", "g", "t", "y", "x", "d", "e", "m", "l", "r", "l"},
            {"p", "m", "p", "e", "e", "a", "m", "p", "z", "r", "i", "x", "g", "m", "h"},
            {"o", "a", "l", "i", "w", "i", "n", "e", "d", "x", "x", "r", "r", "e", "i"},
            {"g", "v", "a", "r", "q", "p", "v", "n", "x", "l", "w", "q", "d", "f", "z"},
            {"f", "b", "m", "o", "s", "c", "o", "u", "m", "m", "u", "m", "b", "a", "i"},
            {"a", "a", "k", "l", "r", "l", "a", "x", "c", "a", "i", "r", "o", "p", "m"},
        };

        String[,] data =
        {
            {"i", "p", "z", "b", "e", "l", "g", "i", "c", "a", "r", "f", "g", "d", "e"},
            {"n", "x", "o", "e", "q", "u", "a", "d", "o", "r", "o", "r", "a", "w", "s"},
            {"g", "z", "b", "r", "a", "s", "i", "l", "k", "w", "p", "a", "c", "a", "p"},
            {"l", "m", "j", "b", "t", "r", "a", "g", "m", "r", "l", "n", "n", "b", "a"},
            {"a", "u", "l", "v", "l", "u", "r", "f", "v", "e", "l", "ç", "t", "t", "n"},
            {"t", "d", "o", "i", "x", "s", "g", "z", "b", "e", "k", "a", "h", "j", "h"},
            {"e", "s", "a", "c", "s", "s", "e", "a", "y", "h", "z", "w", "z", "x", "a"},
            {"r", "p", "v", "n", "z", "i", "l", "m", "l", "g", "x", "r", "s", "s", "z"},
            {"r", "l", "u", "a", "a", "a", "i", "r", "i", "u", "m", "n", "c", "z", "x"},
            {"a", "n", "i", "h", "c", "c", "a", "r", "g", "e", "n", "t", "i", "n", "a"},
            {"d", "i", "n", "a", "m", "a", "r", "c", "a", "h", "j", "i", "t", "c", "f"},
            {"s", "d", "t", "b", "o", "l", "i", "v", "i", "a", "r", "d", "z", "x", "d"},
            {"a", "r", "u", "b", "a", "h", "g", "l", "c", "h", "i", "p", "r", "e", "h"},
            {"c", "o", "r", "e", "i", "a", "h", "o", "l", "a", "n", "d", "a", "y", "k"},
            {"m", "a", "n", "t", "a", "r", "t", "i", "d", "a", "h", "f", "n", "e", "j"},
        };

        public static String[,] tabuleiroPalavras = new string[n_tabuleiros, 19];

        public static String[] novapalavra = new string[19];

        //Palavras base
        public static String[] palavras = {
            "inglaterra",
            "portugal",
            "espanha",
            "argelia",
            "china",
            "russia",
            "antartida",
            "frança",
            "holanda",
            "argentina",
            "belgica",
            "bolivia",
            "brasil",
            "canada",
            "aruba",
            "chipre",
            "coreia",
            "equador",
            "dinamarca"};

        public static String[] palavras0 = {

            "lisboa",
            "porto",
            "madrid",
            "aveiro",
            "xangai",
            "mumbai",
            "moscou",
            "cairo",
            "pequin",
            "toquio",
            "dhaka",
            "londres",
            "delhi",
            "singapura",
            "roma",
            "praga",
            "amesterdam",
            "seul",
            "dubai",};

        public static String[,,] data3 = new String[n_tabuleiros, 15, 15];

        //Cores
        Color[] cor ={
            Color.Coral,
            Color.Red ,
            Color.Yellow,
            Color.Beige,
            Color.Gold,
            Color.Firebrick,
            Color.Aqua,
            Color.Beige,
            Color.ForestGreen,
            Color.Azure,
            Color.Brown,
            Color.BlueViolet,
            Color.Cyan,
            Color.DarkTurquoise,
            Color.Coral,
            Color.Crimson,
            Color.DeepPink,
            Color.Fuchsia,
            Color.DarkOliveGreen,
            Color.Chocolate,
            Color.DarkKhaki,
            Color.Fuchsia,
        };

        String[] abc =
        {
            "a","b","c","d","e","f","g","h","i","j","k","l","m",
            "n","o","p","q","r","s","t","u", "v","w","x","y","z"
        };
        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregar();
            this.inserePalavras();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            textBox1.Enabled = false;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    bt[i, j] = new Button();
                    bt[i, j].Click += new EventHandler(this.teste);
                    // i -colunas j-linhas
                    bt[i, j].Width = 60;
                    bt[i, j].Height = 60;
                    bt[i, j].Name = i + "_" + j;
                    bt[i, j].BackColor = Color.LightGray;
                    tableLayoutPanel1.Controls.Add(bt[i, j], i, j);
                }
            }

        }

        /********************************************************************************************
         *                                  Funções auxiliares                                      *
         ********************************************************************************************/
        private void listartabela()
        {
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (bt[i, x].Text == "")
                    {
                        int randomNumber = random.Next(0, 26);
                        bt[i, x].Text = abc[randomNumber];
                    }
                }
            }
        }
        public void RodaTabuleiro(int m)
        {
            int k, j;

            for (j = 0; j < 15; j++)
            {
                for (k = 0; k < 15; k++)
                {
                    TabuleiroJogo[j, k] = data3[m, k, j];
                }
            }
        }
        //Corrigir o l = indice fora dos limites
        public void RodaTabuleiro2(int m)
        {
            int k, j, l;

            for (j = 0; j < 15; j++)
            {
                for (k = 0, l = 14; k < 15; k++, l--)
                {
                    TabuleiroJogo[l, j] = data3[m, k, j];
                }
            }

        }
        public void RodaTabuleiro3(int m)
        {
            int k, j, l;

            for (j = 0; j < 15; j++)
            {
                for (k = 0, l = 14; k < 15; k++, l--)
                {
                    TabuleiroJogo[j, k] = data3[m, j, l];
                }
            }
        }
        private void carregar2()
        {
            lockpalavras[0, 0] = 0; lockpalavras[0, 1] = 0;
            lockpalavras[1, 0] = 0; lockpalavras[1, 1] = 1;
            lockpalavras[2, 0] = 0; lockpalavras[2, 1] = 2;
            lockpalavras[3, 0] = 0; lockpalavras[3, 1] = 3;
            lockpalavras[4, 0] = 0; lockpalavras[4, 1] = 4;//1 dubai

            lockpalavras[5, 0] = 1; lockpalavras[5, 1] = 7;
            lockpalavras[6, 0] = 1; lockpalavras[6, 1] = 8;
            lockpalavras[7, 0] = 1; lockpalavras[7, 1] = 9;
            lockpalavras[8, 0] = 1; lockpalavras[8, 1] = 10;
            lockpalavras[9, 0] = 1; lockpalavras[9, 1] = 11;//2 porto

            lockpalavras[10, 0] = 2; lockpalavras[10, 1] = 0;
            lockpalavras[11, 0] = 2; lockpalavras[11, 1] = 1; lockpalavras[12, 0] = 2; lockpalavras[12, 1] = 2;
            lockpalavras[13, 0] = 2; lockpalavras[13, 1] = 3; lockpalavras[14, 0] = 2; lockpalavras[14, 1] = 4;
            lockpalavras[15, 0] = 2; lockpalavras[15, 1] = 5; lockpalavras[16, 0] = 2; lockpalavras[16, 1] = 6;
            lockpalavras[17, 0] = 2; lockpalavras[17, 1] = 7; lockpalavras[18, 0] = 2; lockpalavras[18, 1] = 8;//3 singapura

            lockpalavras[19, 0] = 4; lockpalavras[19, 1] = 2; lockpalavras[20, 0] = 4; lockpalavras[20, 1] = 3;
            lockpalavras[21, 0] = 4; lockpalavras[21, 1] = 4; lockpalavras[22, 0] = 4; lockpalavras[22, 1] = 5;
            lockpalavras[23, 0] = 4; lockpalavras[23, 1] = 6; lockpalavras[24, 0] = 4; lockpalavras[24, 1] = 7;
            lockpalavras[25, 0] = 4; lockpalavras[25, 1] = 8; lockpalavras[26, 0] = 4; lockpalavras[26, 1] = 9;
            lockpalavras[27, 0] = 4; lockpalavras[27, 1] = 10; lockpalavras[28, 0] = 4; lockpalavras[28, 1] = 11;//4 amesterdam

            lockpalavras[29, 0] = 0; lockpalavras[29, 1] = 8; lockpalavras[30, 0] = 0; lockpalavras[30, 1] = 9;
            lockpalavras[31, 0] = 0; lockpalavras[31, 1] = 10; lockpalavras[32, 0] = 0; lockpalavras[32, 1] = 11;
            lockpalavras[31, 0] = 0; lockpalavras[31, 1] = 10; lockpalavras[32, 0] = 0; lockpalavras[32, 1] = 11;
            lockpalavras[33, 0] = 0; lockpalavras[33, 1] = 12; lockpalavras[34, 0] = 0; lockpalavras[34, 1] = 13;//5 pequin

            lockpalavras[35, 0] = 6; lockpalavras[35, 1] = 5; lockpalavras[36, 0] = 7; lockpalavras[36, 1] = 5;
            lockpalavras[37, 0] = 8; lockpalavras[37, 1] = 5; lockpalavras[38, 0] = 9; lockpalavras[38, 1] = 5;
            lockpalavras[39, 0] = 10; lockpalavras[39, 1] = 5; lockpalavras[40, 0] = 11; lockpalavras[40, 1] = 5;//xangai

            lockpalavras[41, 0] = 1; lockpalavras[41, 1] = 1;
            lockpalavras[42, 0] = 2; lockpalavras[42, 1] = 1; lockpalavras[43, 0] = 3; lockpalavras[43, 1] = 1;
            lockpalavras[44, 0] = 4; lockpalavras[44, 1] = 1; lockpalavras[45, 0] = 5; lockpalavras[45, 1] = 1;
            lockpalavras[46, 0] = 6; lockpalavras[46, 1] = 1;//lisboa

            lockpalavras[47, 0] = 7; lockpalavras[47, 1] = 0; lockpalavras[48, 0] = 7; lockpalavras[48, 1] = 1;
            lockpalavras[49, 0] = 7; lockpalavras[49, 1] = 2;
            lockpalavras[50, 0] = 7; lockpalavras[50, 1] = 3;//seul

            lockpalavras[51, 0] = 2; lockpalavras[51, 1] = 10;
            lockpalavras[52, 0] = 2; lockpalavras[52, 1] = 11;
            lockpalavras[53, 0] = 2; lockpalavras[53, 1] = 12;
            lockpalavras[54, 0] = 2; lockpalavras[54, 1] = 13;
            lockpalavras[55, 0] = 2; lockpalavras[55, 1] = 14;//praga

            lockpalavras[56, 0] = 6; lockpalavras[56, 1] = 6;
            lockpalavras[57, 0] = 6; lockpalavras[57, 1] = 7;
            lockpalavras[58, 0] = 6; lockpalavras[58, 1] = 8;
            lockpalavras[59, 0] = 6; lockpalavras[59, 1] = 9;
            lockpalavras[60, 0] = 6; lockpalavras[60, 1] = 10;
            lockpalavras[61, 0] = 6; lockpalavras[61, 1] = 11;//toquio

            lockpalavras[62, 0] = 7; lockpalavras[62, 1] = 14;
            lockpalavras[63, 0] = 7; lockpalavras[63, 1] = 13;
            lockpalavras[64, 0] = 7; lockpalavras[64, 1] = 12;
            lockpalavras[65, 0] = 7; lockpalavras[65, 1] = 11;
            lockpalavras[66, 0] = 7; lockpalavras[66, 1] = 10;//dhaka

            lockpalavras[67, 0] = 8; lockpalavras[67, 1] = 1;
            lockpalavras[68, 0] = 9; lockpalavras[68, 1] = 1;
            lockpalavras[69, 0] = 10; lockpalavras[69, 1] = 1;
            lockpalavras[70, 0] = 11; lockpalavras[70, 1] = 1;//roma

            lockpalavras[71, 0] = 13; lockpalavras[71, 1] = 3;
            lockpalavras[72, 0] = 12; lockpalavras[72, 1] = 3;
            lockpalavras[73, 0] = 11; lockpalavras[73, 1] = 3;
            lockpalavras[74, 0] = 10; lockpalavras[74, 1] = 3;
            lockpalavras[75, 0] = 9; lockpalavras[75, 1] = 3;
            lockpalavras[76, 0] = 8; lockpalavras[76, 1] = 3;//aveiro

            lockpalavras[77, 0] = 13; lockpalavras[77, 1] = 2;
            lockpalavras[78, 0] = 13; lockpalavras[78, 1] = 3;
            lockpalavras[79, 0] = 13; lockpalavras[79, 1] = 4;
            lockpalavras[80, 0] = 13; lockpalavras[80, 1] = 5;
            lockpalavras[81, 0] = 13; lockpalavras[81, 1] = 6;
            lockpalavras[82, 0] = 13; lockpalavras[82, 1] = 7;//moscou

            lockpalavras[83, 0] = 13; lockpalavras[83, 1] = 14;
            lockpalavras[84, 0] = 13; lockpalavras[84, 1] = 13;
            lockpalavras[85, 0] = 13; lockpalavras[85, 1] = 12;
            lockpalavras[86, 0] = 13; lockpalavras[86, 1] = 11;
            lockpalavras[87, 0] = 13; lockpalavras[87, 1] = 10;
            lockpalavras[88, 0] = 13; lockpalavras[88, 1] = 9;//mumbai

            lockpalavras[89, 0] = 7; lockpalavras[89, 1] = 14;
            lockpalavras[90, 0] = 8; lockpalavras[90, 1] = 14;
            lockpalavras[91, 0] = 9; lockpalavras[91, 1] = 14;
            lockpalavras[92, 0] = 10; lockpalavras[92, 1] = 14;
            lockpalavras[93, 0] = 11; lockpalavras[93, 1] = 14;//delhi

            lockpalavras[94, 0] = 14; lockpalavras[94, 1] = 12;
            lockpalavras[95, 0] = 14; lockpalavras[95, 1] = 11;
            lockpalavras[96, 0] = 14; lockpalavras[96, 1] = 10;
            lockpalavras[97, 0] = 14; lockpalavras[97, 1] = 9;
            lockpalavras[98, 0] = 14; lockpalavras[98, 1] = 8;//cairo

            lockpalavras[99, 0] = 14; lockpalavras[99, 1] = 14;
            lockpalavras[100, 0] = 13; lockpalavras[100, 1] = 13;
            lockpalavras[101, 0] = 12; lockpalavras[101, 1] = 12;
            lockpalavras[102, 0] = 11; lockpalavras[102, 1] = 11;
            lockpalavras[103, 0] = 10; lockpalavras[103, 1] = 10;
            lockpalavras[104, 0] = 9; lockpalavras[104, 1] = 9;//madrid

            lockpalavras[105, 0] = 14; lockpalavras[105, 1] = 5;
            lockpalavras[106, 0] = 13; lockpalavras[106, 1] = 6;
            lockpalavras[107, 0] = 12; lockpalavras[107, 1] = 7;
            lockpalavras[108, 0] = 11; lockpalavras[108, 1] = 8;
            lockpalavras[109, 0] = 10; lockpalavras[109, 1] = 9;
            lockpalavras[110, 0] = 9; lockpalavras[110, 1] = 10;
            lockpalavras[111, 0] = 8; lockpalavras[111, 1] = 11;
            lockpalavras[112, 0] = 7; lockpalavras[112, 1] = 12;//londres

        }
        public int CarregarTabuleiroRandom()
        {
            Random random = new Random();
            int m = 0;

            for (int i = 0; i < 1000; i++)
            {
                m = random.Next(0, 100);
                if (data3[m, 1, 1] != null)
                {
                    break;
                }
            }

            return m;
        }
        public int TabuleiroIndex()
        {
            indexTabuleiro = 0;

            for (indexTabuleiro = 0; indexTabuleiro < data3.Length; indexTabuleiro++)
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        if (data3[indexTabuleiro, i, j] == null)
                        {
                            return indexTabuleiro;
                        }
                    }
                }
            }
            return -1;
        }
        private void carregar()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    data3[0, i, j] = data[i, j];
                    data3[1, i, j] = data0[i, j];

                }
            }
            for (int i = 0; i < 19; i++) {
                tabuleiroPalavras[0, i] = palavras[i];
                tabuleiroPalavras[1, i] = palavras0[i];
            }
            carregar2();
        }
        private void animacao()
        {
            for (int i = 0; i < 113; i++)
            {
                if (lockpalavras[i, 1] != null)
                {
                    this.Invoke(new Action(() => { bt[lockpalavras[i, 0], lockpalavras[i, 1]].PerformClick(); }));
                    Thread.Sleep(500);
                }
                else
                {
                    t1.Abort();
                    break;
                }

            }
            MessageBox.Show("Fim da demosntração", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void limpar1()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (bt[i, j].BackColor == cor[count_color])
                    {
                        bt[i, j].BackColor = Color.LightGray;
                    }
                }
            }
            count = 0;
        }
        private void teste(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string[] array = clickedButton.Name.Split(new char[] { '_' }, 2);
            n[0] = Convert.ToInt32(array[0]); //coluna
            n[1] = Convert.ToInt32(array[1]); //linha


            if (bt[n[0], n[1]].Text == "")
            {

            }
            else
            {
                clickedButton.BackColor = cor[count_color];

                if (n[0] == 14 && n[1] == 14 && count != 0)
                {
                    if (bt[n[0] - 1, n[1]].BackColor == cor[count_color])
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0], n[1] - 1].BackColor == cor[count_color])
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0] - 1, n[1] - 1].BackColor == cor[count_color])
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
                else if (n[0] == 0 && n[1] == 0 && count != 0)
                {
                    if (bt[n[0] + 1, n[1]].BackColor == cor[count_color])
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0], n[1] + 1].BackColor == cor[count_color])
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0] + 1, n[1] + 1].BackColor == cor[count_color])
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
                else if (n[0] == 0 && n[1] == 14 && count != 0)//canto esquerdo inf
                {
                    if (bt[n[0] + 1, n[1]].BackColor == cor[count_color])
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0], n[1] - 1].BackColor == cor[count_color])
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0] + 1, n[1] - 1].BackColor == cor[count_color])
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
                else if (n[0] == 14 && n[1] == 0 && count != 0)// canto d sup
                {
                    if (bt[n[0] - 1, n[1]].BackColor == cor[count_color])
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0], n[1] + 1].BackColor == cor[count_color])
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if (bt[n[0] - 1, n[1] + 1].BackColor == cor[count_color])
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
                else if (n[0] == 0 && count != 0)// coluna 0
                {
                    if ((bt[n[0] + 1, n[1]].BackColor == cor[count_color]) && (count == 1 || count == 2))
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0], n[1] + 1].BackColor == cor[count_color] || bt[n[0], n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 3))
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] + 1, n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 4))
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] + 1, n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 5))
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }

                }

                else if (n[0] == 14 && count != 0)// coluna 14 
                {
                    if ((bt[n[0] - 1, n[1]].BackColor == cor[count_color]) && (count == 1 || count == 2))
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0], n[1] + 1].BackColor == cor[count_color] || bt[n[0], n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 3))
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 4))
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 5))
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }

                }
                else if (n[1] == 0 && count != 0)//linha 0
                {
                    if ((bt[n[0] + 1, n[1]].BackColor == cor[count_color] || bt[n[0] - 1, n[1]].BackColor == cor[count_color]) && (count == 1 || count == 2))
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0], n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 3))
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] + 1, n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 4))
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 5))
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
                else if (n[1] == 14 && count != 0)//linha 14
                {
                    if ((bt[n[0] - 1, n[1]].BackColor == cor[count_color] || bt[n[0] + 1, n[1]].BackColor == cor[count_color]) && (count == 1 || count == 2))
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0], n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 3))
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 4))
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] + 1, n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 5))
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        count = 1;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1]].BackColor == cor[count_color] || bt[n[0] + 1, n[1]].BackColor == cor[count_color]) && (count == 1 || count == 2))//coluna
                    {
                        count = 2;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0], n[1] - 1].BackColor == cor[count_color] || bt[n[0], n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 3))//linha
                    {
                        count = 3;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1] - 1].BackColor == cor[count_color] || bt[n[0] + 1, n[1] + 1].BackColor == cor[count_color]) && (count == 1 || count == 4))
                    {
                        count = 4;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else if ((bt[n[0] - 1, n[1] + 1].BackColor == cor[count_color] || bt[n[0] + 1, n[1] - 1].BackColor == cor[count_color]) && (count == 1 || count == 5))
                    {
                        count = 5;
                        palavra = palavra + bt[n[0], n[1]].Text;
                        valida();
                    }
                    else
                    {
                        limpar1(); count = 0;
                        palavra = "";
                    }
                }
            }
        }
        private void valida()
        {
            char[] letras = palavra.ToCharArray();
            String inverte = "";
            for (int i = letras.Length - 1; i > -1; i--)
            {
                inverte += letras[i];
            }
            for (int i = 0; i < 19; i++)
            {
                if (palavra == lb[i].Text)
                {
                    chc[i].Checked = true;
                    count = 0;
                    count_color++;
                    palavra = "";
                    check();
                }
                else if (inverte == lb[i].Text)
                {
                    chc[i].Checked = true;
                    count = 0;
                    count_color++;
                    palavra = "";
                    check();
                }
            }
        }
        public void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Faz a contagem 

            Invoke(new Action(() =>
            {
                i += 1;
                if (i == 60)
                {
                    i = 0;
                    j += 1;
                }
                if (j == 60)
                {
                    j = 0;
                    k += 1;
                }
                if (k == 60)
                {
                    k = 0;
                }
                textBox1.Text = string.Format("{2}:{1}:{0}", i.ToString(), j.ToString(), k.ToString());
                tempo = textBox1.Text;

            }));
        }
        public void desempenhoTempo()
        {
            int m;
            m = 0;
            if (tempo != null)
            {
                for (int i = 0; i < 19; i++)
                {
                    if (chc[i].Checked)
                        m++;
                }
                t.Stop();
                int a, b;
                String titulo = "Parabens";
                string[] words = tempo.Split(':');
                a = Convert.ToInt32(words[0]);
                b = Convert.ToInt32(words[1]);
                if (a > 0)
                    MessageBox.Show("Parabens demorou " + words[0] + " horas," + words[1] + " minutos e " + words[2] + " segundos e " + " acertou " + m + " palavras!"
                        , titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else if (b > 0)
                    MessageBox.Show("Parabens demorou " + words[1] + " minutos e " + words[2] + " segundos e" + " acertou " + m + " palavras!"
                        , titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    MessageBox.Show("Parabens demorou " + words[2] + " segundos e" + " acertou " + m + " palavras!"
                        , titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }
        public void check()
        {
            int m = 0;
            for (int i = 0; i < 19; i++)
            {
                if (chc[i].Checked)
                {
                    m++;
                }
                else
                {
                    break;
                }
            }
            if (m == 19)
            {
                int a, b;
                t.Stop();
                String titulo = "Parabens";
                if (tempo == null) { }
                else
                {
                    string[] words = tempo.Split(':');
                    a = Convert.ToInt32(words[0]);
                    b = Convert.ToInt32(words[1]);
                    if (a > 0)
                        MessageBox.Show("Parabens demorou " + words[0] + " horas," + words[1] + " minutos e " + words[2] + " segundos", titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else if (b > 0)
                        MessageBox.Show("Parabens demorou " + words[1] + " minutos e " + words[2] + " segundos", titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Parabens demorou " + words[2] + " segundos", titulo,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

                    //atualizar o tempo do jogador
                    foreach (Jogador j in jogadores)
                    {
                        if (j.nome == Form3.nome)
                        {
                            j.tempo = tempo;
                            jogadores.Add(j);
                            break;
                        }
                    }
                    //Limpar o tabuleiro
                    limparJogo();
                }
            }
            m = 0;

        }
        public void limparJogo()
        {
            count_color = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    bt[i, j].Text = "";
                    bt[i, j].BackColor = Color.LightGray;
                }
            }
            for (int i = 0; i < 19; i++)
            {
                if (lb[i] != null)
                {
                    lb[i].Text = "";
                    tableLayoutPanel2.Controls.Remove(lb[i]);
                    chc[i].Checked = false;
                    tableLayoutPanel2.Controls.Remove(chc[i]);
                }
            }
        }
        private void corfundo(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = cor[count_color];
        }
        public void inserePalavras() {

            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i] != null)
                    palavrasTotal[i] = palavras[i];

            }
            for (int i = 19; i < palavras0.Length + 19; i++)
            {
                if (palavras0[i - 19] != null)
                    palavrasTotal[i] = palavras0[i - 19];

            }
        }

        private void gravartabuleiro()
        {
            bool check = true;

            for (int i = 0; i < 15; i++)
            {
                for (int x = 0; x < 15; x++)
                {
                    if (bt[i, x].Text == "")
                    {
                        check = false;
                    }
                }
            }
            for (int j = 0; j < 19; j++)
            {
                if (novapalavra[j] == null)
                {
                    check = false;
                }


            }
            if (check)
            {
                int id;
                id = TabuleiroIndex();
                for (int i = 0; i < 15; i++)
                {
                    for (int x = 0; x < 15; x++)
                    {
                        data3[id, i, x] = bt[i, x].Text;
                    }
                }
                for (int j = 0; j < 19; j++)
                {                    
                        tabuleiroPalavras[id, i] = novapalavra[i];
                }
                limparJogo();
            }
            else
            {
                MessageBox.Show("Erro!!! é preciso ter 19 parlavras e ter todos os espaços ocupados", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------Fim das funções auxiliares------------------------------------
        //Novo jogo
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            k = 0;
            j = 0;
            int carregar;
            limparJogo();
            //Se não houver jogadores na lista
            if (jogadores?.Any() != true)
            {
                string msg = "Se está a iniciar o jogo com um novo utilizador escolha a opção nome do jogador.";
                string titulo = "Dialogo Alerta";
                MessageBox.Show(msg, titulo,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            //Caso haja jogadores na lista começa o jogo
            else
            {
                carregar = CarregarTabuleiroRandom();
                Random rdm = new Random();
                random = rdm.Next(1, 4);                
                
                switch(random){
                    case 1:
                        RodaTabuleiro(carregar);
                        break;
                    case 2:
                        RodaTabuleiro2(carregar);
                        break;
                    case 3:
                        RodaTabuleiro3(carregar);
                        break;
                    case 4:
                        for (int i = 0; i < 15; i++)
                        {
                            for (int j = 0; j < 15; j++)
                            {
                                TabuleiroJogo[i, j] = data3[carregar,i, j];
                            }
                        }
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        bt[i, j].Text = TabuleiroJogo[i, j];
                    }
                }
                //Add checkbox e labels dos paises
                for (int i = 0; i < 19; i++)
                {
                    chc[i] = new CheckBox();
                    lb[i] = new Label();
                    lb[i].Text = tabuleiroPalavras[carregar, i];
                    tableLayoutPanel2.Controls.Add(chc[i]);
                    chc[i].Checked = false;
                    chc[i].Enabled = false;
                    tableLayoutPanel2.Controls.Add(lb[i]);
                }
                //Inicia o contador
                t.Start();
            }
        }
        //Abandonar app
        private void bt5_Click(object sender, EventArgs e)
        {
            string msg = "Confirma que deseja abandonar a aplicação? ";
            string titulo = "Dialogo Abandonar";
            var dr = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //Nome do jogador
        private void bt2_Click(object sender, EventArgs e)
        {
            nomeJogador.ShowDialog();        
        }

        private void admitirPalavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarPalavras.ShowDialog();
        }

        private void linguagemToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            string msg = "";
            string titulo = "Dialogo Linguagem";
            MessageBox.Show(msg, titulo,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt3_Click(object sender, EventArgs e)
        {
            desempenhoTempo();              
        }
        public void administraçãoAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin.ShowDialog();
            inserePalavras();
            //Se o login for aprovado entra no ciclo
            if (Form6.kek)
            {
                this.criarToolStripMenuItem.Visible = true;
                panel3.Visible = false;
                count_color = 0;
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        bt[i, j].Text = "";
                        bt[i, j].BackColor = Color.LightGray;
                    }
                }
                for (int i = 0; i < 19; i++)
                {
                    if (lb[i] != null)
                    {
                        lb[i].Text = "";
                        tableLayoutPanel2.Controls.Remove(lb[i]);
                        chc[i].Checked = false;
                        tableLayoutPanel2.Controls.Remove(chc[i]);
                    }
                }
            }              
        }
        private void bt4_Click(object sender, EventArgs e)//Jogada anterior
        {
            palavra = "";
            limpar1();
        }

        public void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void listaPalavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPalavras.ShowDialog();
        }
        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criarToolStripMenuItem.Visible = false;
            panel3.Visible = true;
        }
        private void distribuirPalavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 InserePalavras = new Form2();
            InserePalavras.Show();            
        }
        private void gerirAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmimGerir.ShowDialog();
        }
        private void preencherEspaçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listartabela();
        }
        private void gravarFicheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravartabuleiro();
        }

        private void voltarATrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int x = 0; x < 15; x++)
                {
                    bt[i, x].Text =  data3[3, i, x]  ;
                }
            }

        }

        private void apagarAsLetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form8 ApagarTabuleiro = new Form8();                
                ApagarTabuleiro.Show();
        }

        private void nomeJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nomeJogador.ShowDialog();
        }

        private void melhorTempoToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            String[] melhorTempo;
            melhorTempo = new String[2];
            melhorTempo[0] = "Não há registros!";
            melhorTempo[1] = "10:00:00";
            
            if (jogadores?.Any() == true)
            {
                int n1, n2, n3, n4, n5, n6;
                string[] words = melhorTempo[1].Split(':');
                n1 = Convert.ToInt32(words[0]);
                n2 = Convert.ToInt32(words[1]);
                n3 = Convert.ToInt32(words[2]);
                if (tempo == null)
                {
                    MessageBox.Show(melhorTempo[0], "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    n1 = n1 * 10000;
                    n2 = n2 * 100;
                    n1 = n1 + n2 + n3;

                    foreach (Jogador j in jogadores)
                    {
                        string[] tempoWords = j.tempo.Split(':');
                        n4 = Convert.ToInt32(tempoWords[0]);
                        n5 = Convert.ToInt32(tempoWords[1]);
                        n6 = Convert.ToInt32(tempoWords[2]);

                        n4 = n4 * 10000;
                        n5 = n5 * 100;
                        n4 = n4 + n5 + n6;

                        if (n1 > n4)
                        {
                            n1 = n4; 
                            melhorTempo[1] = j.tempo;
                            melhorTempo[0] = j.nome;
                        }
                    }
                    MessageBox.Show(melhorTempo[0]+" "+ melhorTempo[1],"Melhor Tempo!",                   
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }                  
                }
                else
                {
                    MessageBox.Show(melhorTempo[0], "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }            
        }
        private void abandonarAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Confirma que deseja abandonar a aplicação? ";
            string titulo = "Dialogo Abandonar";
            var dr = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void demonstraçãoAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form3.nome!=null)
            {
                MessageBox.Show("Erro tente mais tarde");
            }
            else
            {
                panel3.Visible = false;
                limparJogo();
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        bt[i, j].Text = data3[1, i, j];

                    }
                }
                for (int i = 0; i < 19; i++)
                {
                    chc[i] = new CheckBox();
                    lb[i] = new Label();
                    lb[i].Text = tabuleiroPalavras[1, i];
                    tableLayoutPanel2.Controls.Add(chc[i]);
                    chc[i].Checked = false;
                    chc[i].Enabled = false;
                    tableLayoutPanel2.Controls.Add(lb[i]);
                }
                t1 = new Thread(animacao);
                t1.Start();
                panel3.Visible = true;
            }
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "";
            string titulo = "Dialogo Programa";
            MessageBox.Show(msg, titulo,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string msg = "";
            string titulo = "Dialogo autor";
            MessageBox.Show(msg, titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
