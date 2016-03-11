package computerShopTask;

import java.util.ArrayList;

public class Customer extends Person {
	
	public Customer(){
		
	}
	public Customer(String firstName, String secondName, String custID) {
		super(firstName, secondName, custID);
	}
	
	public static ArrayList<Person> customer = new ArrayList<Person>();
	
	public void addCustomer(Customer n) {
		customer.add(n);
	}
}
