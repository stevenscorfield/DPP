package example;

public class Person {
	private String firstName;
	private String lastName;
	
	//constructor
	public Person(String firstName, String lastName)
	{
		this.firstName = firstName;
		this.lastName = lastName;
	}
	
	//getters and setters
	
	public void setFirstName(String fn) {
		this.firstName = fn;
	}
	
	public String getFirstName()
	{
		return this.firstName;
	}
	
	public void setLastName(String ln) {
		this.lastName = ln;
	}
	
	public String getLastName()
	{
		return this.lastName;
	}

}
