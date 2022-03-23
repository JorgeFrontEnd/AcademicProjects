
namespace SopaDeLetras
{
    partial class App
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abandonarAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melhorTempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admitirPalavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuirPalavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPalavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarFicheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarAsLetrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarATrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preencherEspaçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linguagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 410);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(840, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 410);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt5);
            this.panel3.Controls.Add(this.bt4);
            this.panel3.Controls.Add(this.bt3);
            this.panel3.Controls.Add(this.bt2);
            this.panel3.Controls.Add(this.bt1);
            this.panel3.Location = new System.Drawing.Point(17, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 100);
            this.panel3.TabIndex = 2;
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Red;
            this.bt5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt5.Location = new System.Drawing.Point(823, 24);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(180, 59);
            this.bt5.TabIndex = 4;
            this.bt5.Text = "Abandonar App";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt4.Location = new System.Drawing.Point(634, 24);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(183, 59);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "Jogada Anterior";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt3.Location = new System.Drawing.Point(428, 24);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(200, 59);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "Desempenho";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Location = new System.Drawing.Point(222, 24);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(200, 59);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Nome Jogador";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.SeaShell;
            this.bt1.Location = new System.Drawing.Point(20, 24);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(196, 59);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Novo Jogo";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.criarToolStripMenuItem,
            this.informaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.nomeJogadorToolStripMenuItem,
            this.administraçãoAppToolStripMenuItem,
            this.demonstraçãoAppToolStripMenuItem,
            this.abandonarAppToolStripMenuItem,
            this.melhorTempoToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // nomeJogadorToolStripMenuItem
            // 
            this.nomeJogadorToolStripMenuItem.Name = "nomeJogadorToolStripMenuItem";
            this.nomeJogadorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nomeJogadorToolStripMenuItem.Text = "Nome Jogador";
            this.nomeJogadorToolStripMenuItem.Click += new System.EventHandler(this.nomeJogadorToolStripMenuItem_Click);
            // 
            // administraçãoAppToolStripMenuItem
            // 
            this.administraçãoAppToolStripMenuItem.Name = "administraçãoAppToolStripMenuItem";
            this.administraçãoAppToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.administraçãoAppToolStripMenuItem.Text = "Administração App";
            this.administraçãoAppToolStripMenuItem.Click += new System.EventHandler(this.administraçãoAppToolStripMenuItem_Click);
            // 
            // demonstraçãoAppToolStripMenuItem
            // 
            this.demonstraçãoAppToolStripMenuItem.Name = "demonstraçãoAppToolStripMenuItem";
            this.demonstraçãoAppToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.demonstraçãoAppToolStripMenuItem.Text = "Ver Demonstração";
            this.demonstraçãoAppToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoAppToolStripMenuItem_Click);
            // 
            // abandonarAppToolStripMenuItem
            // 
            this.abandonarAppToolStripMenuItem.Name = "abandonarAppToolStripMenuItem";
            this.abandonarAppToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.abandonarAppToolStripMenuItem.Text = "Abandonar App";
            this.abandonarAppToolStripMenuItem.Click += new System.EventHandler(this.abandonarAppToolStripMenuItem_Click);
            // 
            // melhorTempoToolStripMenuItem
            // 
            this.melhorTempoToolStripMenuItem.Name = "melhorTempoToolStripMenuItem";
            this.melhorTempoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.melhorTempoToolStripMenuItem.Text = "Melhor tempo";
            this.melhorTempoToolStripMenuItem.Click += new System.EventHandler(this.melhorTempoToolStripMenuItem_Click);
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admitirPalavrasToolStripMenuItem,
            this.distribuirPalavrasToolStripMenuItem,
            this.listaPalavrasToolStripMenuItem,
            this.gravarFicheiroToolStripMenuItem,
            this.apagarAsLetrasToolStripMenuItem,
            this.voltarATrasToolStripMenuItem,
            this.preencherEspaçosToolStripMenuItem,
            this.gerirAdministradorToolStripMenuItem});
            this.criarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.criarToolStripMenuItem.Text = "Criar";
            this.criarToolStripMenuItem.Visible = false;
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // admitirPalavrasToolStripMenuItem
            // 
            this.admitirPalavrasToolStripMenuItem.Name = "admitirPalavrasToolStripMenuItem";
            this.admitirPalavrasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.admitirPalavrasToolStripMenuItem.Text = "Admitir Palavras";
            this.admitirPalavrasToolStripMenuItem.Click += new System.EventHandler(this.admitirPalavrasToolStripMenuItem_Click);
            // 
            // distribuirPalavrasToolStripMenuItem
            // 
            this.distribuirPalavrasToolStripMenuItem.Name = "distribuirPalavrasToolStripMenuItem";
            this.distribuirPalavrasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.distribuirPalavrasToolStripMenuItem.Text = "Distribuir Palavras";
            this.distribuirPalavrasToolStripMenuItem.Click += new System.EventHandler(this.distribuirPalavrasToolStripMenuItem_Click);
            // 
            // listaPalavrasToolStripMenuItem
            // 
            this.listaPalavrasToolStripMenuItem.Name = "listaPalavrasToolStripMenuItem";
            this.listaPalavrasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listaPalavrasToolStripMenuItem.Text = "Lista Palavras";
            this.listaPalavrasToolStripMenuItem.Click += new System.EventHandler(this.listaPalavrasToolStripMenuItem_Click);
            // 
            // gravarFicheiroToolStripMenuItem
            // 
            this.gravarFicheiroToolStripMenuItem.Name = "gravarFicheiroToolStripMenuItem";
            this.gravarFicheiroToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gravarFicheiroToolStripMenuItem.Text = "Gravar Ficheiro";
            this.gravarFicheiroToolStripMenuItem.Click += new System.EventHandler(this.gravarFicheiroToolStripMenuItem_Click);
            // 
            // apagarAsLetrasToolStripMenuItem
            // 
            this.apagarAsLetrasToolStripMenuItem.Name = "apagarAsLetrasToolStripMenuItem";
            this.apagarAsLetrasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.apagarAsLetrasToolStripMenuItem.Text = "Apagar Tabuleiros";
            this.apagarAsLetrasToolStripMenuItem.Click += new System.EventHandler(this.apagarAsLetrasToolStripMenuItem_Click);
            // 
            // voltarATrasToolStripMenuItem
            // 
            this.voltarATrasToolStripMenuItem.Name = "voltarATrasToolStripMenuItem";
            this.voltarATrasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.voltarATrasToolStripMenuItem.Text = "Voltar Atras";
            this.voltarATrasToolStripMenuItem.Click += new System.EventHandler(this.voltarATrasToolStripMenuItem_Click);
            // 
            // preencherEspaçosToolStripMenuItem
            // 
            this.preencherEspaçosToolStripMenuItem.Name = "preencherEspaçosToolStripMenuItem";
            this.preencherEspaçosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.preencherEspaçosToolStripMenuItem.Text = "Preencher Espaços";
            this.preencherEspaçosToolStripMenuItem.Click += new System.EventHandler(this.preencherEspaçosToolStripMenuItem_Click);
            // 
            // gerirAdministradorToolStripMenuItem
            // 
            this.gerirAdministradorToolStripMenuItem.Name = "gerirAdministradorToolStripMenuItem";
            this.gerirAdministradorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gerirAdministradorToolStripMenuItem.Text = "Gerir Administrador";
            this.gerirAdministradorToolStripMenuItem.Click += new System.EventHandler(this.gerirAdministradorToolStripMenuItem_Click);
            // 
            // informaçãoToolStripMenuItem
            // 
            this.informaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linguagemToolStripMenuItem,
            this.programaToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.informaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informaçãoToolStripMenuItem.Name = "informaçãoToolStripMenuItem";
            this.informaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.informaçãoToolStripMenuItem.Text = "Informação";
            // 
            // linguagemToolStripMenuItem
            // 
            this.linguagemToolStripMenuItem.Name = "linguagemToolStripMenuItem";
            this.linguagemToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.linguagemToolStripMenuItem.Text = "Linguagem";
            this.linguagemToolStripMenuItem.Click += new System.EventHandler(this.linguagemToolStripMenuItem_Click);
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.programaToolStripMenuItem.Text = "Programa";
            this.programaToolStripMenuItem.Click += new System.EventHandler(this.programaToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 15;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(964, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "00:00:00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(840, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 19;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 410);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(906, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tempo";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abandonarAppToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admitirPalavrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuirPalavrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPalavrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarFicheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarAsLetrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarATrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preencherEspaçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linguagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem gerirAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem melhorTempoToolStripMenuItem;
    }
}

