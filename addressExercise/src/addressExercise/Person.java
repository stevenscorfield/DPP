package addressExercise;

public class Person {
	Address address;
	String firstName;
	String lastName;
	
	Person(String fn, String ln,String fLine, String sLine, String state) {
		this.firstName = fn;
		this.lastName = ln;
		
		address = new Address(fLine, sLine, state);
	}
	
}
