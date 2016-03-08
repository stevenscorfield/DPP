package exercises;

public class Solution {
	public static void main(String[] args) {
    	
		new ValidateGui();
 
    }
 
    public static String check(String username) {
        int length = 0;
        int letters = 0;
        int digits = 0;
        int symbols = 0;
        int spaces = 0;
 
        for (char ch : username.toCharArray()) {
            if (Character.isLetter(ch)) {
                letters++;
            } else if (Character.isDigit(ch)) {
                digits++;
            } else if (ch == '@' || ch == '#' || ch == '*' || ch == '=') {
                symbols++;
            } else if (Character.isSpaceChar(ch)) {
                spaces++;
            }
            length++;
        }
 
        if ((length >= 5 && length <= 10) && letters > 0 && digits > 0
                && symbols > 0 && spaces == 0) {
            return "PASS";
        }
        return "FAIL";
    }
}
