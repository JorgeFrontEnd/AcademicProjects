//class
public class vlan extends Object implements Comparable<vlan> {
	// Atributos
	private String vlan, maq, interf, equi, modo;
	private int total, dim;

	// construrores
	vlan() {

	}

	vlan(String v, String m, String i, String e, String o) {
		this.vlan = v;
		this.maq = m;
		this.interf = i;
		this.equi = e;
		this.modo = o;
		this.total = Integer.parseInt(String.valueOf(m)) + 3;
	}

	// Metodos set
	public void setInterf(String x) {
		this.interf = x;
	}

	public void setVlan(String x) {
		this.vlan = x;
	}

	public void setMaq(String x) {
		this.maq = x;
	}

	public void setTotal(int x) {
		this.total = x;
	}

	public void setDim(int x) {
		this.dim = x;
	}

	// Metodos get
	public String getInterf() {
		return this.interf;
	}

	public String getVlan() {
		return this.vlan;
	}

	public String getMaq() {
		return this.maq;
	}

	public String getEqui() {
		return this.equi;
	}

	public String getModo() {
		return this.modo;
	}

	public int getTotal() {
		return this.total;
	}

	public int getDim() {
		return this.dim;
	}

	@Override
	public int compareTo(vlan v){
		return(v.getTotal()-this.total);
	}
}