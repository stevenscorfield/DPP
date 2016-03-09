package InventoryPart1;

public class Inventory {	
	
	//creates a new array
	static Product products[] = new Product[5];
	
	public static void main(String[] args){
		
		//array indices
		products[0] = new Product (1000, "Black Pen", 0.05, 2000);
		products[1] = new Product (1001, "Blue Pen", 0.05, 2045);
		products[2] = new Product (1100, "Printer Paper", 1.50, 1000);
		products[3] = new Product (1110, "Lined Pad", 0.50, 550);
		products[4] = new Product (1120, "Blank Pad", 0.50, 200);

		sortByName();
		
		//creates a loop to go through above array (get is used to obtain the item at index)
		for (Product p : products){
			p.output();
		}
		double totalInventory = 0;
		for (int i = 0; i < products.length; i++){
			totalInventory = totalInventory + products[i].getTotal();
		}
			
			
		//keep out of loop! if in loop each will one will use method
		System.out.println("Total Value of all Inventory: £" + totalInventory);		
	}
	
	public static void sortByName() {
		int n = products.length;
		boolean swapped;
		do {
			swapped = false;
			for (int i = 0; i < n - 1; i++) {
				String name1 = products[i].Name;
				String name2 = products[i + 1].Name;
				if (name1.compareToIgnoreCase(name2) > 0) {
					// swap
					Product temp = products[i];
					products[i] = products[i + 1];
					products[i + 1] = temp;
					swapped = true;
				}
			}
			n = n - 1;
		} while (swapped);
	}
}
