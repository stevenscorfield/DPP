package operatorExamples;

import java.util.Scanner;

public class Switch {

	public static void main(String[] args) 
	{
		Switch1();
	}
	static void Switch1 ()
	{ 
		System.out.println("What size ice cream cone would you like? 1 = small, 2 = medium, 3 = large, 4 = extra large.");
		
		Scanner scan = new Scanner(System.in);
		//creates a variable to show the number input by the user and selects it according to the switch
		int size = scan.nextInt();
		//creates a variable to show the cost of the cone
		double cost = 0;
		
		switch (size) {
		case 1: 
			cost = 1.25;
			break;
		case 2: 
			cost = 2.25;
			break;
		case 3: 
			cost = 3.25;
			break;
		case 4: 
			cost = 4.25;
			break;
		default:
			System.out.println("Unknown input");
			break;
		}
		//will only print out a message if 1 between 4 is selected
		if (size > 0 && size < 5) 
		{
			System.out.println("The price of cone " + size + " is: " + cost);
		}
	}
}


