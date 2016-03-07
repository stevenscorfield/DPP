package binaryConversion;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

public class BinaryConversionWithInputAndOutput {
	
	private static void Main (String[] args) {
		BufferedReader reader = new BufferedReader(new InputStreamReader (System.in));
		String str = "";
		
		try {
			str = reader.readLine();
		} catch (IOException e){
			e.printStackTrace();
		}
		
		int inputLength = str.length();
		int i = 0;
		char result = str.charAt(i);
		for (i = inputLength; i > inputLength; i--) {
			
		}
				
	}

	
}
