package addressExercise;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;


public class AddressBook {
	static Person[] addresses = new Person[500];
			
	String[] data;

		
	File file = new File("Address.txt");
	
	//reads from a text file and puts it into an array
	public void loadFromFile() {
		//declares scanner object as s
		Scanner s;
		//try to see if file is present or not corrupted
		try {
			//creates a new scanner object using s
			s = new Scanner(file);
			
			//a loop to go through .txt file
			while (s.hasNextLine()){
				//creates a string variable for a next line scanner
				String line = s.nextLine();
				//separates each line in its word components. each word is split by a comma
				data = line.split(",");
				//will go through each line and print the line until the end
				for(int i=0; i < data.length; i++)
					System.out.println(data[i]);
			}
		} catch (FileNotFoundException e) {
			System.out.println("No file present or file has been corrupted");
		}
		//loop to produce each member of the array 
		finally {
			System.out.println("Bye!");
		}
	}
		
	public static void main(String[] args){
		AddressBook adr = new AddressBook();
		adr.loadFromFile();
		
		
		
		sortByName();
	}
	
	public static void sortByName() {
		int n = addresses.length;
		boolean swapped;
		do {
			swapped = false;
			for (int i = 0; i < n - 1; i++) {
				String name1 = addresses[i].fn;
				String name2 = addresses[i + 1].fName;
				if (name1.compareToIgnoreCase(name2) > 0) {
					// swap
					Person temp = addresses[i];
					addresses[i] = addresses[i + 1];
					addresses[i + 1] = temp;
					swapped = true;
				}
			}
			n = n - 1;
		} while (swapped);
	}	
	//addresses[0] = new AddressLine ();
}
