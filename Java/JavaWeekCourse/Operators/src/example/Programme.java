package example;

import java.util.List;

public class Programme {

	public static void main(String[] args) {
		whileLoopTest();

	}
	
	static void whileLoopTest() {
		List<Person> people = Data.GetPeople();
		
		System.out.println("While Loop Test");
		System.out.println("FirstName, LastName");
		System.out.println("-------------------");
		
		//counter
		int counter = 0;
		while(counter <= people.size() - 1)
		{
			System.out.println(people.get(counter).getFirstName() 
					+ ", " + people.get(counter).getLastName());
			
			counter++;
		}
	}
	
	static void forLoopTest() {
		List<Person> people = Data.GetPeople();
		
		System.out.println("For Loop Test");
		System.out.println("FirstName, LastName");
		System.out.println("-------------------");
		
		for (int i=0; i < people.size()- 1; i++) {
			System.out.println(people.get(i).getFirstName() 
					+ ", " + people.get(i).getLastName());
			
		}
	}

}
