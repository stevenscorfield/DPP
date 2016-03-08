package InventoryPart1;

import java.util.ArrayList;
import java.util.List;

public class Inventory {
	Product.Price = price;
	
	
	public static void main(String[] args){
		List<Product> products = new ArrayList<Product>();
		/*
		Product penBl = new Product (1000, "Black Pen", 0.05, 2000);
		Product penB2 = new Product (1001, "Blue Pen", 0.05, 2045);
		Product paperP = new Product (1100, "Printer Paper", 1.50, 1000);
		Product padLined = new Product (1110, "Lined Pad", 0.50, 550);
		Product padBlank = new Product (1120, "Blank Pad", 0.50, 200);
		*/
		
		//creates a list array (uses object list)
		products.add(new Product (1000, "Black Pen", 0.05, 2000));
		products.add(new Product (1001, "Blue Pen", 0.05, 2045));
		products.add(new Product (1100, "Printer Paper", 1.50, 1000));
		products.add(new Product (1110, "Lined Pad", 0.50, 550));
		products.add(new Product (1120, "Blank Pad", 0.50, 200));
		
		//creates a loop to go through above list array (get is used to obtain the item at index)
		for (int i = 0; i < products.size(); i++){
		products.get(i).output();
		}
		System.out.println("The total value of stock is: £" + ((Product.Price * Product.Stock) * products.size()));
		//public static value () {
		//	for (int = )
		}
		/*
		penB2.output();
		paperP.output();
		padLined.output();
		padBlank.output();
		*/
		
	}
	
	
//}
