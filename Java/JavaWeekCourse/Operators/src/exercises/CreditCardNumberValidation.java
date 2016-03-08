package exercises;

import java.util.Scanner;

public class CreditCardNumberValidation {
 
    public static void main(String[] args) {
        @SuppressWarnings("resource")
		Scanner kbd = new Scanner(System.in);
        System.out.print("Enter a credit card number as a long integer: ");
        long number = kbd.nextLong();
 
        if (isValid(number)) {
            System.out.println(number + " is valid");
        } else {
            System.out.println(number + " is invalid");
        }
 
    }
 
    /** Return true if the card number is valid */
    public static boolean isValid(long number) {
        int step2 = sumOfDoubleEvenPlace(number);
        int step3 = sumOfOddPlace(number);
        int step4 = step2 + step3;
 
        if (step4 % 10 == 0) {
            boolean visa = prefixMatched(number, 4);
            boolean master = prefixMatched(number, 5);
            boolean amex = prefixMatched(number, 37);
            boolean discover = prefixMatched(number, 6);
            return visa || master || amex || discover;
        }
 
        return false;
    }
 
    /** Get the result from Step 2 */
    public static int sumOfDoubleEvenPlace(long number) {
        char[] digits = String.valueOf(number).toCharArray();
        int sum = 0;
        for (int i = digits.length - 2; i >= 0; i -= 2) {
            int digit = Character.getNumericValue(digits[i]);
            sum += getDigit(digit * 2);
        }
        return sum;
    }
 
    /**
     * Return this number if it is a single digit, otherwise, return the sum of
     * the two digits
     */
    public static int getDigit(int number) {
        if (getSize(number) == 2) {
            int digit1 = number / 10;
            int digit2 = number % 10;
            return digit1 + digit2;
        }
        return number;
    }
 
    /** Return sum of odd place digits in number */
    public static int sumOfOddPlace(long number) {
        char[] digits = String.valueOf(number).toCharArray();
        int sum = 0;
        for (int i = digits.length - 1; i >= 0; i -= 2) {
            int digit = Character.getNumericValue(digits[i]);
            sum += digit;
        }
        return sum;
    }
 
    /** Return true if the digit d is a prefix for number */
    public static boolean prefixMatched(long number, int d) {
        long prefix = getPrefix(number, getSize(d));
        return prefix == d;
    }
 
    /** Return the number of digits in d */
    public static int getSize(long d) {
        return String.valueOf(d).length();
    }
 
    /**
     * Return the first k number of digits from number. If the number of digits
     * in number is less than k, return number.
     */
    public static long getPrefix(long number, int k) {
        if (getSize(number) < k) {
            return number;
        }
        // Compute log of the abs(number), then get floor.
        long a = Math.abs(number);
        double floor = Math.floor(Math.log10(a));
        // Divide the number with 10^floor
        return (long) (a / Math.pow(10, floor));
 
    }
}
