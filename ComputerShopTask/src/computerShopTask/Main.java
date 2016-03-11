package computerShopTask;

import java.util.Scanner;

public class Main {
	
	//creates an object based on stock array
	static Stock mystock = new Stock();
	static Customer mycust = new Customer();
	//prints console screen
	public static void addMenu(){
		System.out.println("<---------------------------------->");
		System.out.println("             Main Menu              ");
		System.out.println("<---------------------------------->");
		System.out.println("C - Create a new Computer");
		System.out.println("N - Create a new Customer");
		System.out.println("S - Search");
		System.out.println("O - Order or otherwise sort Computers");
		System.out.println("L - List or otherwise sort Computers");
		System.out.println("Q - Quit");
	}
	
	//creates the user input
	static void addScanner () {
		Scanner scan = new Scanner(System.in);
		String input = scan.nextLine();		
		System.out.println(input);
		
		//checks to see what the user added
		switch(input.toLowerCase()) {
		case "c": 
			addComputer(scan);
			break;
		case "n":
			addCustomer(scan);
			break;
		case "s":
			search();
			break;
		case "o":
			//orderComp();
			break;
		case "l":
			//listComp();
			break;
		case "q":
			System.exit(0);
			break;
		default:
			System.out.println("Not a valid selection!");
			break;
		}
	}
	//creates a method to add a new computer to array
	static void addComputer(Scanner input) {
		System.out.println("Is this computer a laptop or desktop?");
		System.out.println("Please enter L for laptop or D for desktop.");
		//Scanner typeComp = new Scanner(System.in);
		String type = input.next();
		//if to check whether it's a desktop or laptop
		if (type == "l"){
			addLaptopComputer(input);
		}
		else {
			addDesktopComputer(input);
		}
		
		System.out.print(mystock.stock.get(10).make);
	}
	
	//method to add laptop
	static void addLaptopComputer(Scanner input){
		//Scanner addcomp = new Scanner(System.in);
		String component = input.next();
		//component = "";
		System.out.println("Please enter the details of the computer you wish to add to the system");
		
		System.out.println("Please enter Model: ");
		String make = input.nextLine();
		System.out.println("Please enter ID: ");
		String iD = input.nextLine();
		System.out.println("Please enter CPU: ");
		String cpu = input.nextLine();
		System.out.println("Please enter RAM: ");
		String ram = input.nextLine();
		System.out.println("Please enter HDD size: ");
		String hdd = input.nextLine();
		System.out.println("Please enter GPU: ");
		String gpu = input.nextLine();
		System.out.println("Computer has now been added to system.");
		//creates a new object array based on laptop
		Laptop lp = new Laptop(make, iD, cpu, ram, hdd, gpu);
		mystock.addComputer(lp);
	}
	
	//method to add desktop
	static void addDesktopComputer(Scanner input){
		//Scanner addcomp = new Scanner(System.in);
		String component = input.nextLine();
		//component = "";
		System.out.println("Please enter the details of the computer you wish to add to the system");
		
		System.out.println("Please enter Model: ");
		String make = input.nextLine();
		System.out.println("Please enter ID: ");
		String iD = input.nextLine();
		System.out.println("Please enter CPU: ");
		String cpu = input.nextLine();
		System.out.println("Please enter RAM: ");
		String ram = input.nextLine();
		System.out.println("Please enter HDD size: ");
		String hdd = input.nextLine();
		System.out.println("Please enter GPU: ");
		String gpu = input.nextLine();
		System.out.println("Computer has now been added to system.");
		//creates a new object array based on desktop
		Desktop dp = new Desktop(make, iD, cpu, ram, hdd, gpu);
		mystock.addComputer(dp);
	}
	
	static void addCustomer(Scanner input){
		//Scanner addcust = new Scanner(System.in);
		//String newcust = input.next();
		//component = "";
		System.out.println("Please enter the details of the customer that you the system");
		System.out.println("Please enter customer's first name: ");
		String firstName = input.nextLine();
		System.out.println("Please enter customer's second name: ");
		String secondName = input.nextLine();
		System.out.println("Please enter Customer ID: ");
		String custID = input.nextLine();
		Customer nc = new Customer(firstName, secondName, custID);
		mycust.addCustomer(nc);
		System.out.print(mycust.customer.get(0).firstName);
	}
		
	static void search(){
		Scanner search = new Scanner(System.in);
		String searched = (search.nextLine());
		
	}
	
	public static void main(String[] args) {
		addMenu();
		addScanner();
	}
}
