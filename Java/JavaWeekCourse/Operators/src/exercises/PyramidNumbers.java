package exercises;
import java.util.Scanner;

public class PyramidNumbers {

	public static void main(String[] args) {
        @SuppressWarnings("resource")
		final Scanner kb = new Scanner(System.in);
 
        final int input1 = Integer.parseInt(kb.nextLine());
        final int input2 = Integer.parseInt(kb.nextLine());
        final int input3 = Integer.parseInt(kb.nextLine());
 
        printPiramid(input1);
        printPiramid(input2);
        printPiramid(input3);
    }
 
    public static void printPiramid(int height) {
        int blanks = 0;
        for (int count = 0; count <= height; count++) {
            blanks = height - count;
            for (int b = 0; b < blanks; b++) {
                System.out.print(" ");
            }
            for (int c = 0; c < count; c++) {
                System.out.print(count + " ");
            }
            if (count < height)
                System.out.println();
        }
    }

}
