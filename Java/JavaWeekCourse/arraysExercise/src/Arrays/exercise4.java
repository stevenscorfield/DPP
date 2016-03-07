package Arrays;

public class exercise4 {
	
	public static void main(String[] args){
		//declares to int vars for 2 arrays
		int a [] =  {1, 2, 3};
		int b [] = {3, 3, 3};
		//this will be run
		commonEnd(a, b);
		System.out.println(commonEnd(a, b));
	}

	//tells commonEnd to use variables a and b
	public static boolean  commonEnd(int a[], int b[]){
		if ((a[0] > b[0] || a[a.length - 1] > b[b.length - 1]) && (a.length > 1 && b.length > 1)) {
			return true;
		}
		else {
			return false;
		}
	}
		
}
