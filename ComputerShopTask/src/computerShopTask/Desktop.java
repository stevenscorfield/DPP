package computerShopTask;

public class Desktop extends Computer {
	double monitor;
	
	public Desktop(String make, String iD, String cpu, String ramMemory, String hddMemory, 
			String gpu){
		super(make, iD, cpu, ramMemory, hddMemory, gpu);
		this.monitor = monitor;
	}
	
	public double getMonitor() {
		return this.monitor;
	}
}
