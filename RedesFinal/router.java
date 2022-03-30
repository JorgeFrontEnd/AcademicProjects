public class router extends Object{
    // Atributos
    private String vlan, maq,total, dim, oct3, rede, inicio,fim,broadcast,cidr,mascara;//11

    // construrores
    router() {

    }

    router(String v, String m, String t, String d, String o,String r,String i,String f,String b,String c, String mas) {
        this.vlan = v;
        this.maq = m;
        this.total = t;
        this.dim = d;
        this.oct3 = o;
        this.rede = r;
        this.inicio = i;
        this.fim = f;
        this.broadcast = b;
        this.cidr = c;
        this.mascara = mas;
    }

    // Metodos set

    public void setVlan(String x)       {this.vlan = x;}
    public void setMaq(String x)        {this.maq = x;}
    public void setTotal(String x)      {this.total = x;}
    public void setOct3(String x)       {this.oct3 = x;}
    public void setDim(String x)           {this.dim = x;}
    public void setRede(String x)          {this.rede = x;}
    public void setInicio(String x)     {this.inicio = x;}
    public void setFim(String x)        {this.fim = x;}
    public void setBroadcast(String x)  {this.broadcast = x;}
    public void setCidr(String x)        {this.cidr = x;}
    public void setMascara(String x)    {this.mascara = x;}

    // Metodos get
    public String getVlan()         {return this.vlan;}
    public String getMaq()         {return this.maq;}
    public String getTotal()      {return this.total;}
    public String getOct3()         {return this.oct3;}
    public String getDim()          {return this.dim;}
    public String getRede()      {return this.rede;}
    public String getInicio()     {return this.inicio;}
    public String getFim()          {return this.fim;}
    public String getBroadcast() {return this.broadcast;}
    public String getCidr()      {return this.cidr;}
    public String getMascara()     {return this.mascara;}


}
