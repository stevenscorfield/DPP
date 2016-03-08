package exercises;

import java.util.Random;
import java.util.Scanner;

class Lottery {

	/**
	 * The lottery numbers.
	 */
	private int lotteryNumbers[];

	/**
	 * Default Constructor.
	 *
	 * The class should use the Random class (from the Java API) to generate a
	 * random number in the range of 0 through 9 for each element in the array.
	 */
	public Lottery() {
		Random rand = new Random(System.currentTimeMillis());
		lotteryNumbers = new int[5];
		for (int i = 0; i < lotteryNumbers.length; i++) {
			//lotteryNumbers[i] = Math.abs(rand.nextInt()) % 10;
			lotteryNumbers[i] = Math.abs(rand.nextInt(10)); //return random between 0 - 9
			System.out.println(lotteryNumbers[i]);
		}
	}

	/**
	 * The class should also have a method that accepts an array of 5 integers
	 * that represent a person's lottery picks. The method is to compare the
	 * corresponding elements in the two arrays and return the number of digits
	 * that match.
	 */
	public int compareNumbers(int[] usersNumbers) {
		int match = 0;
		if (usersNumbers.length == lotteryNumbers.length) {
			for (int i = 0; i < lotteryNumbers.length; i++) {
				if (usersNumbers[i] == lotteryNumbers[i]) {
					match++;
				}
			}
		}
		return match;
	}

	/**
	 * In addition, the class should have a method that returns a copy of the
	 * lotteryNumbers array.
	 */
	public int[] getLotteryNumbers() {
		return lotteryNumbers;
	}
}

/**
 * Demonstrate the class in a program that asks the user to enter five numbers.
 * The program should display the number of digits that match the randomly
 * generate lottery numbers. If all of the digits match, display a message
 * proclaiming the user a grand prize winner.
 */
public class LotteryApplication {
	public static void main(String[] args) {
		Lottery lottery = new Lottery();
		int lotteryNumbersCount = lottery.getLotteryNumbers().length;

		System.out.println("Lottery Application\n");
		System.out.println("There are " + lotteryNumbersCount
				+ " secret numbers in range of 0 through 9. "
				+ "Try to guess them!!!\n");

		// Asks the user to enter five numbers.
		@SuppressWarnings("resource")
		Scanner kb = new Scanner(System.in);
		int numbers[] = new int[lotteryNumbersCount];

		for (int i = 0; i < numbers.length; i++) {
			System.out.print(String.format("Enter Number %d: ", i + 1));
			numbers[i] = kb.nextInt();
		}

		// Display the number of digits that match the randomly generate
		// lottery numbers.

		int match = lottery.compareNumbers(numbers);

		if (match == lotteryNumbersCount) {

			// If all of the digits match, display a message proclaiming the
			// user a grand prize winner.
			System.out.println("\nWOHOO! ALL CORRECT! YOU WON THE BIG PRIZE!");

		} else {
			System.out.println("\nUh-oh! You hit " + match + " number(s).");
		}
	}
}