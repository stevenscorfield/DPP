package Class;

public class Husky extends Dog implements Robotic {
	@Override
	public void bark() {
		System.out.println("Husky says I'm awesome...");
	}
	
	@Override
	public void walk() {
		System.out.println("Husky walks on two front legs");
	}
	

}
