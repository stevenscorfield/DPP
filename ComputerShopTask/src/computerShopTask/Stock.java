package computerShopTask;

import java.util.ArrayList;

public class Stock {
	public static ArrayList<Computer> stock = new ArrayList<Computer>();
	
	public Stock() {
		stock.add(new Laptop("MacBook Pro", "1000", "Core i3", "4 GB", "500 GB", "NVidea Iris"));
		stock.add(new Laptop("MacBook Pro", "1001", "Core i5", "8 GB", "1 TB", "NVidea 10FX"));
		stock.add(new Laptop("Dell", "1002", "Core i7", "6 GB", "500 GB", "NVidea 1000"));
		stock.add(new Laptop("Dell", "1003", "Core i3", "10 GB", "1 TB", "NVidea Geforce 8"));
		stock.add(new Laptop("Lenova", "1004", "Core i5", "4 GB", "500 GB", "NVidea Iris"));
		
		stock.add(new Desktop("iMac", "2000", "Core i7", "10 GB", "2 TB", "NVidea GeForce 10000"));
		stock.add(new Desktop("HP", "2001", "Core i3", "5 GB", "500 GB", "NVidea GeForce 1"));
		stock.add(new Desktop("Dell", "2002", "Core i5", "8 GB", "1 TB", "NVidea GeForce 1000"));
		stock.add(new Desktop("iMac", "2003", "Core i5", "6 GB", "1 TB", "NVidea GeForce 1000FX"));
		stock.add(new Desktop("Acer", "2004", "Core i3", "4 GB", "750 GB", "NVidea Iris"));
	}
	
	//method to add a computer to the system
	public void addComputer(Computer c) {
		stock.add(c);
	}
	
}
