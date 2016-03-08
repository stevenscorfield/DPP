package InventoryPart1;

public class Product {
	//declares the variables
	int idCode;
	String Name;
	double Price;
	int Stock;
	double stockVal;
	
	//declaring the constructor
	Product (int id, String n, double p, int s) {
		idCode = id;
		Name = n;
		Price = p;
		Stock = s;
	}
	
	void Value () {
		stockVal = this.Price * this.Stock;
	}
	//producing a generic object message
	void output () {
		System.out.print("Item ID: " + this.idCode + ", Name: " + this.Name + ", Price: £" + this.Price + ", Units in stock: " + this.Stock);
		System.out.println(", Value of inventory: £" + (this.Price * this.Stock));
	}
}
