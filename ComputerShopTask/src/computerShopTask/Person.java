package computerShopTask;

public abstract class Person {
	String firstName;
	String secondName;
	String custID;
	
	public Person() {
		
	}
	
	public Person (String firstName, String secondName, String custID){
		this.firstName = firstName;
		this.secondName = secondName;
		this.custID = custID;
	}

}
