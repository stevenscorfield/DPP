package computerShopTask;

public abstract class Computer {
	String make;
	String cpu;
	String gpu;
	String iD;
	String hddMemory;
	String ramMemory;
	
	public Computer(String make, String iD, String cpu, String ramMemory, String hddMemory,
			String gpu) {
		this.make = make;
		this.iD = iD;
		this.cpu = cpu;
		this.ramMemory = ramMemory;
		this.hddMemory = hddMemory;
		this.gpu = gpu;
	}	
}
	
