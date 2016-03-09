package InventoryPart1;


public class Product {
	//declares the variables
	int idCode;
	String Name;
	double Price;
	int Stock;
	private double totalValue;
	
	
	public double getTotal(){
		totalValue = this.Price * this.Stock;
		return totalValue;
	}
	public double getPrice () {
		return Price;
	}
	
	public int getStock () {
		return Stock;
	}
	
	//declaring the constructor
	public Product (int id, String n, double p, int s) {
		idCode = id;
		Name = n;
		Price = p;
		Stock = s;
	}
	
	//producing a generic object message
	void output () {
		System.out.print("Item ID: " + this.idCode + ", Name: " + this.Name + ", Price: £" + this.Price + ", Units in stock: " + this.Stock);
		System.out.println(", Value of inventory: £" + getTotal());
	}

	}
