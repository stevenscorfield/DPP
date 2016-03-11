package computerShopTask;

public class Laptop extends Computer {
	double width;
	double height;
	double length;
	double weight;
	double batteryLife;
	

	public Laptop(String make, String iD, String cpu, String ramMemory, String hddMemory, 
			String gpu){
		super(make, iD, cpu, ramMemory, hddMemory, gpu);
		this.weight = weight;
		this.length = length;
		this.height = height;
		this.batteryLife = batteryLife;
	}
	
	public double getWidth() {
		return this.width;
	}
	public double getLength() {
		return this.length;
	}
	public double getHeight() {
		return this.height;
	}
	public double getWeight() {
		return this.height;		
	}
	public double getBatteryLife() {
		return this.batteryLife;		
	}
}
	
