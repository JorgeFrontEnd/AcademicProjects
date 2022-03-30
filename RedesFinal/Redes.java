
/*
Trabalho realizado por Jorge Ramalhete
*/
//Bibliotecas
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import java.util.*;
import java.io.*;
import javax.swing.JTable;

public class Redes extends JFrame implements ActionListener {
    // Variaveis, listas etc..
    static java.util.List<vlan> list = new ArrayList<>();
    static java.util.List<vlan> list2 = new ArrayList<>();
    static java.util.List<router> list3 = new ArrayList<>();
    private static final long serialVersionUID = 1l;
    static int total = 0;
    static JFrame Frame = new JFrame();
    JRadioButton sim, nao;
    static FileWriter arqW;
    static PrintWriter arqP;
    static FileReader arqR;
    static BufferedReader arqB;
    ImageIcon icon, icon2, icon3;
    JMenu File, About;
    JMenuBar mnb;
    JMenuItem LoadTabela, LoadRouter, LoadSwitch, SaveRouter, SaveSwitch, PacketTracer, Putty, Abandonar, Programa,
            Linguagem, Autor;
    JTabbedPane Tab;
    JPanel p1, p2, p2norte, p2centro, p2sul, p3, p3norte, p3centro, p3sul, p4, p4norte, p4centro, p4sul, p5, p5norte,
            p5centro, p5sul;
    JLabel lb;
    static JTable table, table2;
    static JTextField hostname, console, telnet, admin, hostname1, console1, telnet1, admin1, hostname2, console2,
            telnet2, admin2;
    static JTextField IP, vlan;
    JScrollPane scroll;
    static JTextArea ta;
    static JTextArea ta2;
    static JTextArea ta3;
    JButton btvlan[] = new JButton[2];
    JButton btip[] = new JButton[3];
    JButton btswitch[] = new JButton[6];
    JButton btrouter[] = new JButton[3];
    ImageIcon iconvlan[] = { new ImageIcon("infocube.gif"), new ImageIcon("infosrc.gif"), new ImageIcon("object.gif") };
    ImageIcon iconvlan2[] = { new ImageIcon("infocube.gif"), new ImageIcon("object.gif") };
    ImageIcon iconswitch[] = { new ImageIcon("infocube.gif"), new ImageIcon("infosrc.gif"), new ImageIcon("object.gif"),
            new ImageIcon("infocube.gif"), new ImageIcon("infosrc.gif"), new ImageIcon("object.gif") };

    static String Switch[] = { "en \nconf t\n", "vlan ", "exit\n", "int ", "switchport mode ",
            "switchport access vlan ", "do wr" };
    static String Switch1;
    static String Router[] = { "en\nconf t \nint fa0/0\nno shutdown\n\n", "int fa0/0.", "encapsulation dot1q ",
            "ip address ", "ip helper-address ", "no shutdown\n", "exit\n", "do wr\n" };
    static String Router1;

    public Redes() {

        mnb = new JMenuBar();
        File = new JMenu("File");
        About = new JMenu("About");

        // Declaração dos MenuItem
        LoadTabela = new JMenuItem("Load Tabela");
        LoadTabela.addActionListener(this);
        LoadRouter = new JMenuItem("LoadRouter");
        LoadRouter.addActionListener(this);
        LoadSwitch = new JMenuItem("LoadSwitch");
        LoadSwitch.addActionListener(this);
        SaveRouter = new JMenuItem("SaveRouter");
        SaveRouter.addActionListener(this);
        SaveSwitch = new JMenuItem("SaveSwitch");
        SaveSwitch.addActionListener(this);
        PacketTracer = new JMenuItem("PacketTracer");
        PacketTracer.addActionListener(this);
        Putty = new JMenuItem("Putty");
        Putty.addActionListener(this);
        Abandonar = new JMenuItem("Abandonar");
        Abandonar.addActionListener(this);
        Programa = new JMenuItem("Programa");
        Programa.addActionListener(this);
        Linguagem = new JMenuItem("Linguagem");
        Linguagem.addActionListener(this);
        Autor = new JMenuItem("Autor");
        Autor.addActionListener(this);

        // Menu File
        File.add(LoadTabela);
        File.addSeparator();
        File.add(LoadRouter);
        File.add(LoadSwitch);
        File.addSeparator();
        File.add(SaveRouter);
        File.add(SaveSwitch);
        File.addSeparator();
        File.add(PacketTracer);
        File.add(Putty);
        File.addSeparator();
        File.add(Abandonar);

        icon2 = new ImageIcon("");
        File.setIcon(icon2);

        // Menu About
        About.add(Programa);
        About.add(Linguagem);
        About.addSeparator();
        About.add(Autor);

        // Icons menu
        icon = new ImageIcon("redball.gif");
        LoadTabela.setIcon(icon);
        LoadRouter.setIcon(icon);
        LoadSwitch.setIcon(icon);
        SaveRouter.setIcon(icon);
        SaveSwitch.setIcon(icon);
        PacketTracer.setIcon(icon);
        Putty.setIcon(icon);
        Abandonar.setIcon(icon);
        Programa.setIcon(icon);
        Linguagem.setIcon(icon);
        Autor.setIcon(icon);

        mnb.add(File);
        mnb.add(About);
        setJMenuBar(mnb);

        // Capa
        ImageIcon imgcapa = new ImageIcon("img1.jpg");
        p1 = new JPanel(new GridLayout(1, 1));
        lb = new JLabel(imgcapa);
        p1.add(lb);

        Tab = new JTabbedPane();
        Tab.setTabPlacement(1);

        // Tabela de dados iniciais
        String TabelaV[] = { "Vlan", "Maquina", "Interface", "Equipamento", "Modo", }; // String da tabela inicial

        Object TabelaVlan[][] = new Object[50][TabelaV.length];

        // String dos botões para os ciclos for
        String btfor[] = { "Carregar", "Calcular", "Apagar" };
        String btfor4[] = { "Carregar", "Apagar" };
        String btfor2[] = { "Switch1", "Gravar", "Anular", "Switch2", "Gravar", "Anular" };
        String btfor3[] = { "Router", "Gravar", "Anular" };

        p2 = new JPanel(new BorderLayout());

        // Painel 2 centro
        table = new JTable(TabelaVlan, TabelaV);
        scroll = new JScrollPane(table);
        p2.add(scroll, BorderLayout.CENTER);

        // Painel 2 sul
        p2sul = new JPanel();

        for (int i = 0; i < btvlan.length; i++) {
            btvlan[i] = new JButton(btfor4[i], iconvlan2[i]);
            btvlan[i].addActionListener(this);

            p2sul.add(btvlan[i]);
        }
        p2.add(p2sul, BorderLayout.SOUTH);

        // Tabela de destribuição
        String TabelaD[] = { "Vlan", "Maq", "Total", "Dim", "Oct2", "Rede", "Inicio", "Fim", "BroadCast", "CIDR",
                "Mascara" };

        Object TabelaIP[][] = new Object[50][TabelaD.length];

        p3 = new JPanel(new BorderLayout());

        // Painel 3 norte
        p3norte = new JPanel();

        lb = new JLabel("Ip de Rede");
        IP = new JTextField("", 15);
        p3norte.add(lb);
        p3norte.add(IP);

        sim = new JRadioButton();
        nao = new JRadioButton();
        ButtonGroup G = new ButtonGroup();
        G.add(sim);
        G.add(nao);
        sim.setSelected(true);
        lb = new JLabel("Segmentação");
        p3norte.add(lb);
        lb = new JLabel("Sim");
        p3norte.add(lb);
        p3norte.add(sim);
        lb = new JLabel("Não");
        p3norte.add(lb);
        p3norte.add(nao);

        p3.add(p3norte, BorderLayout.NORTH);

        // Painel 3 centro
        table2 = new JTable(TabelaIP, TabelaD);
        scroll = new JScrollPane(table2);
        p3.add(scroll, BorderLayout.CENTER);

        // Painel 3 sul
        p3sul = new JPanel();
        for (int i = 0; i < btip.length; i++) {
            btip[i] = new JButton(btfor[i], iconvlan[i]);
            btip[i].addActionListener(this);
            p3sul.add(btip[i]);
        }
        p3.add(p3sul, BorderLayout.SOUTH);

        // Switch e Programação
        p4 = new JPanel(new BorderLayout());
        p4norte = new JPanel();
        p4norte.setLayout(null);
        p4norte.setPreferredSize(new Dimension(1200, 135));

        // Label esquerda
        lb = new JLabel("Switch");
        lb.setBounds(150, 10, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Switch2");
        lb.setBounds(1000, 10, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Hostname");
        lb.setBounds(50, 40, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Console");
        lb.setBounds(50, 60, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Telnet");
        lb.setBounds(50, 80, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Admin");
        lb.setBounds(50, 100, 70, 20);
        p4norte.add(lb);

        // Label direita
        lb = new JLabel("Hostname");
        lb.setBounds(900, 40, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Console");
        lb.setBounds(900, 60, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Telnet");
        lb.setBounds(900, 80, 70, 20);
        p4norte.add(lb);
        lb = new JLabel("Admin");
        lb.setBounds(900, 100, 70, 20);
        p4norte.add(lb);

        // TextFields esquerda
        hostname = new JTextField("hostname");
        hostname.setBounds(110, 40, 140, 20);
        p4norte.add(hostname);
        console = new JTextField("CCNA");
        console.setBounds(110, 60, 140, 20);
        p4norte.add(console);
        telnet = new JTextField("telnet");
        telnet.setBounds(110, 80, 140, 20);
        p4norte.add(telnet);
        admin = new JTextField("Cisco");
        admin.setBounds(110, 100, 140, 20);
        p4norte.add(admin);

        // Pergunta a vlan do server ao user
        lb = new JLabel("Qual a vlan do servidor ?");
        p4norte.add(lb);
        lb.setBounds(512, 50, 150, 20);
        vlan = new JTextField();
        vlan.setBounds(510, 70, 150, 20);
        p4norte.add(vlan);

        // TextField direita
        hostname1 = new JTextField("hostname");
        hostname1.setBounds(960, 40, 140, 20);
        p4norte.add(hostname1);
        console1 = new JTextField("CCNA");
        console1.setBounds(960, 60, 140, 20);
        p4norte.add(console1);
        telnet1 = new JTextField("telnet");
        telnet1.setBounds(960, 80, 140, 20);
        p4norte.add(telnet1);
        admin1 = new JTextField("Cisco");
        admin1.setBounds(960, 100, 140, 20);
        p4norte.add(admin1);

        p4.add(p4norte, BorderLayout.NORTH);

        // Painel 4 centro
        p4centro = new JPanel(new GridLayout(1, 2));
        ta = new JTextArea();
        scroll = new JScrollPane(ta);
        p4centro.add(scroll);
        ta2 = new JTextArea();
        scroll = new JScrollPane(ta2);
        p4centro.add(scroll);

        p4.add(p4centro, BorderLayout.CENTER);

        // Painel 4 sul
        p4sul = new JPanel(new FlowLayout(FlowLayout.CENTER, 20, 5));
        for (int i = 0; i < btswitch.length; i++) {
            btswitch[i] = new JButton(btfor2[i], iconswitch[i]);
            btswitch[i].addActionListener(this);
            p4sul.add(btswitch[i]);
        }
        p4.add(p4sul, BorderLayout.SOUTH);

        // Router Programação
        p5 = new JPanel(new BorderLayout());
        p5norte = new JPanel();
        p5norte.setLayout(null);
        p5norte.setPreferredSize(new Dimension(1200, 135));

        // Labels
        lb = new JLabel("Router");
        lb.setBounds(50, 10, 70, 20);
        p5norte.add(lb);
        lb = new JLabel("Hostname");
        lb.setBounds(30, 40, 70, 20);
        p5norte.add(lb);
        lb = new JLabel("Console");
        lb.setBounds(30, 60, 70, 20);
        p5norte.add(lb);
        lb = new JLabel("Telnet");
        lb.setBounds(30, 80, 70, 20);
        p5norte.add(lb);
        lb = new JLabel("Admin");
        lb.setBounds(30, 100, 70, 20);
        p5norte.add(lb);

        // TextFileds
        hostname2 = new JTextField("hostname");
        hostname2.setBounds(110, 40, 140, 20);
        p5norte.add(hostname2);
        console2 = new JTextField("CCNA");
        console2.setBounds(110, 60, 140, 20);
        p5norte.add(console2);
        telnet2 = new JTextField("telnet");
        telnet2.setBounds(110, 80, 140, 20);
        p5norte.add(telnet2);
        admin2 = new JTextField("Cisco");
        admin2.setBounds(110, 100, 140, 20);
        p5norte.add(admin2);

        p5.add(p5norte, BorderLayout.NORTH);

        // Painel 5 centro
        p5centro = new JPanel(new GridLayout(1, 1));
        ta3 = new JTextArea();
        scroll = new JScrollPane(ta3);
        p5centro.add(scroll);

        p5.add(p5centro, BorderLayout.CENTER);

        // Painel 5 sul
        p5sul = new JPanel();
        for (int i = 0; i < btrouter.length; i++) {
            btrouter[i] = new JButton(btfor3[i], iconvlan[i]);
            btrouter[i].addActionListener(this);
            p5sul.add(btrouter[i]);
        }
        p5.add(p5sul, BorderLayout.SOUTH);

        // Adicionar os Tabs
        Tab.addTab("Capa da Aplicação", p1);
        Tab.addTab("Tabela de dados iniciais ", p2);
        Tab.addTab("Tabela de Distribuição de Ip ", p3);
        Tab.addTab("Switch´s e programação", p4);
        Tab.addTab("Router programação", p5);

        getContentPane().add(Tab, BorderLayout.CENTER);

        // Dados da Frame
        setSize(1200, 900);
        setResizable(false);
        setVisible(true);

    }

    // Abre o PacketTracer
    public void PacketTracer() throws Exception {
        String[] cmdArrayX1 = new String[1];
        cmdArrayX1[0] = "D:/Cisco Packet Tracer 6.2sv/bin/PacketTracer6.exe"; // mudar caminho caso seja deu desejo
        Process pX = Runtime.getRuntime().exec(cmdArrayX1);
    }

    // Abre o putty
    public void PuTTY() throws Exception {
        String[] cmdArrayX = new String[1];
        cmdArrayX[0] = "C:/Program Files/PuTTY/putty.exe"; // mudar caminho caso seja deu desejo
        Process pX = Runtime.getRuntime().exec(cmdArrayX);
    }

    // Dialogo base
    public static void DialogoBase(String string, String string1, ImageIcon icon) {
        JOptionPane.showMessageDialog(null, string, string1, JOptionPane.OK_OPTION, icon);
    }

    // Dialogo de abandonar
    public static int DialogoAbandono(String string, String string1, ImageIcon icon, int opt) {
        int n = JOptionPane.showConfirmDialog(Frame, string, string1, JOptionPane.YES_NO_OPTION, opt, icon);
        return n;
    }

    // Carrega um ficheiro
    public static void CarregarVlan() throws IOException {
        Object[] dados = new Object[5];
        StringTokenizer leitura;
        vlan v;
        String separador = "\\,";
        String linha;
        int i;

        try {
            arqR = new FileReader("vlan.dat");
            arqB = new BufferedReader(arqR);
            linha = arqB.readLine();
            while (linha != null) {
                leitura = new StringTokenizer(linha, separador);
                i = 0;
                while (leitura.hasMoreElements()) {
                    dados[i] = leitura.nextElement();
                    i++;
                }
                v = new vlan((String) dados[0], // vlan
                        (String) dados[1], // maquinas
                        (String) dados[2], // Interface
                        (String) dados[3], // Equipamento
                        (String) dados[4]);// Modo

                list.add(v);
                linha = arqB.readLine();
            }
            arqB.close();
        } catch (IOException ioe) {
        }
    }

    // Carrega a primeira tabela
    public static void CarregarTabelaIP() {
        vlan v;
        for (int i = 0; i < 50; i++) {
            if (table.getValueAt(i, 0) != null) {
                v = new vlan((String) table.getValueAt(i, 0), (String) table.getValueAt(i, 1),
                        (String) table.getValueAt(i, 2), (String) table.getValueAt(i, 3),
                        (String) table.getValueAt(i, 4));

                list2.add(v);
            }
        }
    }

    // Lista os dados da primeira tabela
    public static void ListarTabela() {
        int i = 0;
        for (vlan v : list) {
            table.setValueAt(v.getVlan(), i, 0);
            table.setValueAt(v.getMaq(), i, 1);
            table.setValueAt(v.getInterf(), i, 2);
            table.setValueAt(v.getEqui(), i, 3);
            table.setValueAt(v.getModo(), i, 4);
            i++;
        }
    }

    // Calcula dimensao
    public static int funcDim(int M) {
        int[] Vdim = { 4, 8, 16, 32, 64, 128, 256 };
        int aux = 0;
        for (int ct = 0; ct <= Vdim.length; ct++)
            if (M <= Vdim[ct]) {
                aux = Vdim[ct];
                break;
            }
        return aux;
    }

    // Calcula a mascara
    public static String funcMasc(int M) {
        String[] vmascara = { "252", "248", "240", "224", "192", "128", "0" };
        int[] Vdim = { 4, 8, 16, 32, 64, 128, 256 };
        String auxm = " ";
        for (int ct = 0; ct <= vmascara.length; ct++)
            if (M <= Vdim[ct]) {
                auxm = "255.255.255." + vmascara[ct];
                break;
            }
        return auxm;
    }

    // Calcula o cidr
    public static String funcCidr(int M) {
        String[] vcidr = { "/30", "/29", "/28", "/27", "/26", "/25", "/24" };
        ;
        int[] Vdim = { 4, 8, 16, 32, 64, 128, 256 };
        String auxm = " ";
        for (int ct = 0; ct <= vcidr.length; ct++)
            if (M <= Vdim[ct]) {
                auxm = vcidr[ct];
                break;
            }
        return auxm;
    }

    // Calcula a tabela com segmentação
    public static void comsegmen() {

        String tmaq;
        int dim, sdim = 0, oct = 0;

        for (int j = 0; j < 50; j++) {
            if (table2.getValueAt(j, 0) != null) {
                tmaq = (String) table2.getModel().getValueAt(j, 2).toString();
                dim = funcDim(Integer.parseInt(String.valueOf(tmaq)));
                table2.setValueAt(dim, j, 3);
                table2.setValueAt(funcCidr(dim), j, 9);
                table2.setValueAt(funcMasc(dim), j, 10);
                if (j == 0) {
                    table2.setValueAt(oct, j, 4);
                    sdim = sdim + dim;
                    table2.setValueAt(oct, j, 5);
                    table2.setValueAt(1, j, 6);
                    table2.setValueAt(sdim - 2, j, 7);
                    table2.setValueAt(sdim - 1, j, 8);
                } else if (sdim < 256) {
                    table2.setValueAt(oct, j, 4);
                    table2.setValueAt(sdim, j, 5);
                    table2.setValueAt(sdim + 1, j, 6);
                    sdim = sdim + dim;
                    table2.setValueAt(sdim - 2, j, 7);
                    table2.setValueAt(sdim - 1, j, 8);
                } else if (sdim >= 256) {
                    oct++;
                    sdim = 0;
                    table2.setValueAt(oct, j, 4);
                    table2.setValueAt(sdim, j, 5);
                    table2.setValueAt(sdim + 1, j, 6);
                    sdim = sdim + dim;
                    table2.setValueAt(sdim - 2, j, 7);
                    table2.setValueAt(sdim - 1, j, 8);
                }
            }
        }
    }

    // Calcula a tabela sem segmentação
    public static void semsegmen() {

        String tmaq;
        int dim, sdim = 0, oct = 0;

        for (int i = 0; i < 50; i++) {
            if (table2.getValueAt(i, 0) != null) {
                tmaq = (String) table2.getModel().getValueAt(0, 2).toString();
                dim = funcDim(Integer.parseInt(String.valueOf(tmaq)));
                table2.setValueAt(dim, i, 3);
                table2.setValueAt(funcCidr(dim), i, 9);
                table2.setValueAt(funcMasc(dim), i, 10);
                if (i == 0) {
                    table2.setValueAt(oct, i, 4);
                    sdim = sdim + dim;
                    table2.setValueAt(oct, i, 5);
                    table2.setValueAt(1, i, 6);
                    table2.setValueAt(sdim - 2, i, 7);
                    table2.setValueAt(sdim - 1, i, 8);
                } else if (sdim < 256) {
                    table2.setValueAt(oct, i, 4);
                    table2.setValueAt(sdim, i, 5);
                    table2.setValueAt(sdim + 1, i, 6);
                    sdim = sdim + dim;
                    table2.setValueAt(sdim - 2, i, 7);
                    table2.setValueAt(sdim - 1, i, 8);
                } else if (sdim >= 256) {
                    oct++;
                    sdim = 0;
                    table2.setValueAt(oct, i, 4);
                    table2.setValueAt(sdim, i, 5);
                    table2.setValueAt(sdim + 1, i, 6);
                    sdim = sdim + dim;
                    table2.setValueAt(sdim - 2, i, 7);
                    table2.setValueAt(sdim - 1, i, 8);
                }
            }
        }
    }

    // Atribui o IP
    public static void AtribuiIP() {

        String ip[] = new String[4];
        for (int i = 0; i < 50; i++) {
            if (table2.getValueAt(i, 0) != null) {
                total += (Integer) table2.getModel().getValueAt(i, 3);

                if (total > 256)
                    IP.setText("172.16.0.0");
                else {
                    IP.setText("192.168.XXX.0");
                }
            }
        }
    }

    // Lista a vlan e a maq na segunda tabela
    public static void ListarTabela2() {
        int i = 0;

        for (vlan v : list2) {
            if (!v.getVlan().equals("--")) {
                table2.setValueAt(v.getVlan(), i, 0);
                table2.setValueAt(v.getMaq(), i, 1);
                i++;
            }
        }
    }

    // Listar a tabela com os calculos
    public static void ListarTabela3() {
        int i = 0;

        for (vlan v : list2) {
            if (!v.getVlan().equals("--")) {
                table2.setValueAt(v.getVlan(), i, 0);
                table2.setValueAt(v.getMaq(), i, 1);
                table2.setValueAt(v.getTotal(), i, 2);
                table2.setValueAt(v.getDim(), i, 3);
                i++;
            }
        }
    }

    // Limpa a tabela inicial
    public static void LimparTabela() {

        for (int i = 0; i < table.getRowCount(); i++) {
            table.setValueAt(null, i, 0);
            table.setValueAt(null, i, 1);
            table.setValueAt(null, i, 2);
            table.setValueAt(null, i, 3);
            table.setValueAt(null, i, 4);
        }
    }

    // Limpa a tabela de destribuição
    public static void LimparTabelaIP() {

        for (int i = 0; i < table2.getRowCount(); i++) {
            table2.setValueAt(null, i, 0);
            table2.setValueAt(null, i, 1);
            table2.setValueAt(null, i, 2);
            table2.setValueAt(null, i, 3);
            table2.setValueAt(null, i, 4);
            table2.setValueAt(null, i, 5);
            table2.setValueAt(null, i, 6);
            table2.setValueAt(null, i, 7);
            table2.setValueAt(null, i, 8);
            table2.setValueAt(null, i, 9);
            table2.setValueAt(null, i, 10);
        }
    }

    // Programação do Switch
    public static void ProgramacaoSwit(String swt) {
        int i = 0;
        Switch1 = Switch[0];// inico

        if (swt == "Switch1") {
            Switch1 += "hostname " + hostname.getText() + "\nline console\npassword " + console.getText()
                    + "\nlogin\nline vty 0 15\npassword " + telnet.getText() + "\n login\nenable password "
                    + admin.getText() + "\n";
            for (vlan v : list) {// vlan's
                if (!v.getVlan().equals("--"))
                    Switch1 += Switch[1] + v.getVlan() + "\n";
            }
        } else if (swt == "Switch2") {
            Switch1 += "hostname " + hostname1.getText() + "\nline console\npassword " + console1.getText()
                    + "\nlogin\nline vty 0 15\npassword " + telnet1.getText() + "\n login\nenable password "
                    + admin1.getText() + "\n";
            for (vlan v : list) {// vlan's
                if (v.getEqui().equals(swt) && !v.getVlan().equals("--"))
                    Switch1 += Switch[1] + v.getVlan() + "\n";
            }
        }

        Switch1 += Switch[2];
        for (vlan v : list) {
            if (v.getEqui().equals(swt) && v.getVlan().equals("--")) {
                Switch1 += Switch[3] + v.getInterf() + "\n" + Switch[4] + v.getModo() + "\n" + Switch[2];
                break;
            }
        }
        for (vlan v : list) {
            if (v.getEqui().equals(swt) && !v.getVlan().equals("--")) {
                Switch1 += Switch[3] + v.getInterf() + "\n";
                Switch1 += Switch[5] + v.getVlan() + "\n" + Switch[2];
            }
        }
        for (vlan v : list) {
            if (v.getEqui().equals(swt) && v.getVlan().equals("--")) {
                if (i > 0) {
                    Switch1 += Switch[3] + v.getInterf() + "\n" + Switch[4] + v.getModo() + "\n" + Switch[2];
                    break;
                }
                i++;
            }
        }
        Switch1 += Switch[2] + Switch[6];
    }

    // Grava o Switch1
    public static void GravarSwitch1(String nf) throws IOException {

        arqW = new FileWriter(nf);
        ta.write(arqW);
    }

    // Grava o Switch2
    public static void GravarSwitch2(String nf) throws IOException {

        arqW = new FileWriter(nf);
        ta2.write(arqW);
    }

    // Grava o router
    public static void GravarRouter(String nf) throws IOException {

        arqW = new FileWriter(nf);
        ta3.write(arqW);
    }

    // Programação do Router
    public static void ProgramacaoRouter() {
        String str = IP.getText();
        String strv = vlan.getText();
        String oct3 = " ";
        String redini = " ";
        // System.out.println(str);
        String[] arr = str.split("\\.");
        String ip = arr[0] + arr[1];
        Router1 = " ";
        Router1 += "en" + "\nconf t" + "\nhostname " + hostname2.getText() + "\nline console\npassword "
                + console2.getText() + "\nlogin\nline vty 0 15\npassword " + telnet2.getText()
                + "\n login\nenable password " + admin2.getText() + "\n";
        Router1 += Router[0];
        for (router r : list3) {
            if (r.getVlan().equals(strv)) {
                oct3 = r.getOct3();
                redini = r.getInicio();
                Router1 += Router[1] + r.getVlan() + "\n" + Router[2] + r.getVlan() + "\n" + Router[3] + arr[0] + "."
                        + arr[1] + "." + oct3 + "." + r.getFim() + " " + r.getMascara() + "\n" + Router[5] + Router[6]
                        + "\n";

            }
        }
        for (router r : list3) {
            if (!r.getVlan().equals("10")) {
                Router1 += Router[1] + r.getVlan() + "\n" + Router[2] + r.getVlan() + "\n" + Router[3] + arr[0] + "."
                        + arr[1] + "." + r.getOct3() + "." + r.getFim() + " " + r.getMascara() + "\n" + Router[4]
                        + arr[0] + "." + arr[1] + "." + oct3 + "." + redini + "\n" + Router[5] + Router[6];
            }
        }
        Router1 += Router[7] + Router[6];
    }

    // Programação do Router
    public static void ProgramacaoRouter2() {
        String str = IP.getText();
        String strv = vlan.getText();
        String oct3 = " ";
        String redini = " ";
        String[] arr = str.split("\\.");
        String ip = arr[0] + arr[1];
        Router1 = " ";
        Router1 += "en" + "\nconf t" + "\nhostname " + hostname2.getText() + "\nline console\npassword "
                + console2.getText() + "\nlogin\nline vty 0 15\npassword " + telnet2.getText()
                + "\n login\nenable password " + admin2.getText() + "\n";
        Router1 += Router[0];
        for (router r : list3) {
            if (r.getVlan().equals(strv)) {
                oct3 = r.getOct3();
                redini = r.getInicio();
                Router1 += Router[1] + r.getVlan() + "\n" + Router[2] + r.getVlan() + "\n" + Router[3] + arr[0] + "."
                        + arr[1] + "." + arr[2] + "." + r.getFim() + " " + r.getMascara() + "\n" + Router[5] + Router[6]
                        + "\n";
            }
        }
        for (router r : list3) {
            if (!r.getVlan().equals("10")) {
                Router1 += Router[1] + r.getVlan() + "\n" + Router[2] + r.getVlan() + "\n" + Router[3] + arr[0] + "."
                        + arr[1] + "." + arr[2] + "." + r.getFim() + " " + r.getMascara() + "\n" + Router[4] + arr[0]
                        + "." + arr[1] + "." + arr[2] + "." + redini + "\n" + Router[5] + Router[6];
            }
        }
        Router1 += Router[7] + Router[6];
    }

    public static void CarregarTabelaFinal() {
        router r2;
        for (int i = 0; i < table2.getRowCount(); i++) {
            if (table2.getValueAt(i, 0) != null) {
                r2 = new router((String) table2.getValueAt(i, 0), (String) table2.getValueAt(i, 1),
                        (String) table2.getValueAt(i, 2).toString(), (String) table2.getValueAt(i, 3).toString(),
                        (String) table2.getValueAt(i, 4).toString(), (String) table2.getValueAt(i, 5).toString(),
                        (String) table2.getValueAt(i, 6).toString(), (String) table2.getValueAt(i, 7).toString(),
                        (String) table2.getValueAt(i, 8).toString(), (String) table2.getValueAt(i, 9),
                        (String) table2.getValueAt(i, 10));
                list3.add(r2);
            }
        }
    }

    public void actionPerformed(ActionEvent e) {

        // Abre o PacketTracer
        if (e.getSource() == PacketTracer) {
            try {
                PacketTracer();
            } catch (Exception e1) {
                e1.printStackTrace();
            }
        }
        // Abre o Putty
        if (e.getSource() == Putty) {
            try {
                PuTTY();
            } catch (Exception e1) {
                e1.printStackTrace();
            }
        }
        // Sai do programa
        if (e.getSource() == Abandonar) {
            int opt = 0;
            String dialogo = "Confirma que deseja abandonar o programa?";
            String dialogo2 = "Dialogo Abandonar";
            ImageIcon iconAbandonar = new ImageIcon("Abandonar.gif");
            opt = DialogoAbandono(dialogo, dialogo2, iconAbandonar, opt);
            if (opt == 0) {
                System.gc();
                System.exit(0);
            }
        }
        // Dialogo do Autor
        if (e.getSource() == Autor) {
            String dialogo = "Autor: Jorge Ramalhete\n\nFunção: Aluno ATEC\nTurma:TPSI PL 1020\n\nMake thing´s easy";
            String dialogo2 = "Dialogo do Autor";
            ImageIcon iconAutor = new ImageIcon("bart.gif");
            DialogoBase(dialogo, dialogo2, iconAutor);
        }
        // Dialogo Linguagem
        if (e.getSource() == Linguagem) {
            String dialogo = "Software House:Sun Micro Systems\n Software: Oracle Corporation\n\n Linguagem: Java\nVersão: 15.0\n\nWrite once run anywhere";
            String dialogo2 = "Dialogo da Linguagem";
            ImageIcon iconLinguagem = new ImageIcon("fight.gif");
            DialogoBase(dialogo, dialogo2, iconLinguagem);
        }
        // Dialogo Programa
        if (e.getSource() == Programa) {
            String dialogo = "Versão: 1.0\nData: 22/4/2021 \n\nAplicação para configurar\nativos de rede Switch e Router\n\nUtilização da programação para realizar aplicações\n\nTrabalho prático TPSI PL 1020";
            String dialogo2 = "Dialogo do Programa";
            ImageIcon iconPrograma = new ImageIcon("img2.jpg");
            DialogoBase(dialogo, dialogo2, iconPrograma);
        }

        // Botao carrega na tabela de dados iniciais
        if (e.getSource() == btvlan[0] || e.getSource() == LoadTabela) {
            try {
                list.clear();
                CarregarVlan();
                ListarTabela();
            } catch (IOException e1) {
                e1.printStackTrace();
            }
        }
        // Botao apaga na tabela de dados iniciais
        if (e.getSource() == btvlan[1]) {
            list.clear();
            LimparTabela();
        }
        // Botao carregar na tabela de destribuição
        if (e.getSource() == btip[0]) {
            list2.clear();
            CarregarTabelaIP();
            ListarTabela2();
        }
        // Botao calcular na tabela de destribuição
        if (e.getSource() == btip[1]) {
            if (sim.isSelected()) {
                LimparTabelaIP();
                Collections.sort(list2);
                ListarTabela3();
                comsegmen();
                AtribuiIP();
            } else {
                LimparTabelaIP();
                Collections.sort(list2);
                ListarTabela3();
                semsegmen();
                AtribuiIP();
            }
        }
        // Botao limpar na tabela de destribuição
        if (e.getSource() == btip[2]) {
            list.clear();
            LimparTabelaIP();
            IP.setText("");
        }
        // Botão que escreve a programação do switch1
        if (e.getSource() == btswitch[0] || e.getSource() == LoadSwitch) {
            Switch1 = " ";
            ProgramacaoSwit("Switch1");
            ta.append(Switch1);
        }
        // Botão que grava a programação num ficheiro do switch1
        if (e.getSource() == btswitch[1] || e.getSource() == SaveSwitch) {
            try {
                GravarSwitch1("Switch1.dat");
            } catch (IOException e1) {
                e1.printStackTrace();
            }
        }
        // Botão que anula
        if (e.getSource() == btswitch[2]) {
            Switch1 = "";
            ta.setText("");
        }
        // Botão que escreve a programação do switch2
        if (e.getSource() == btswitch[3] || e.getSource() == LoadSwitch) {
            Switch1 = " ";
            ProgramacaoSwit("Switch2");
            ta2.append(Switch1);
        }
        // Botão que grava a programação num ficheiro do switch2
        if (e.getSource() == btswitch[4] || e.getSource() == SaveSwitch) {
            try {
                GravarSwitch2("Switch2.dat");
            } catch (IOException e1) {
                e1.printStackTrace();
            }
        }
        // Botão que anula
        if (e.getSource() == btswitch[5]) {
            Switch1 = "";
            ta2.setText("");
        }
        // Programação do router
        if (e.getSource() == btrouter[0] || e.getSource() == LoadRouter) {
            CarregarTabelaFinal();
            if (total > 256)
                ProgramacaoRouter();
            else
                ProgramacaoRouter2();
            ta3.append(Router1);
        }
        // Grava a programação do Router
        if (e.getSource() == btrouter[1] || e.getSource() == SaveRouter) {
            try {
                GravarRouter("Router.dat");
            } catch (IOException e1) {
                e1.printStackTrace();
            }
        }
        // Botão que anula
        if (e.getSource() == btrouter[2]) {
            Router1 = "";
            ta3.setText("");
        }
    }

    public static void main(String[] args) {

        Redes app = new Redes();
    }
}