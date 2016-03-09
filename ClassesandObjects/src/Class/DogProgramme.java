package Class;

public class DogProgramme {

	public static void main(String[] args) {
		Dog dog = DogFactory.buildDog(DogType.HANDSOME);
		dog.bark();
	}

}
