package example;

import java.util.ArrayList;
import java.util.List;

public class Data {
	
	public static List<Person> GetPeople() {
		final List<Person> peopleList = new ArrayList<Person>();
		
		peopleList.add(new Person("Alex", "Kennedy"));
		peopleList.add(new Person("David", "Beckham"));
	
		return peopleList;
	}
}
