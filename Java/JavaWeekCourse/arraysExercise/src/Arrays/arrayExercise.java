package Arrays;

public class arrayExercise {
	
	public static void main(String[] args){
		//int setArray [] =  {3, 1, 2, 3};
		//int check [];
		//firstLast(setArray);
		//System.out.println(firstLast(setArray));
		//sameFirstLast(setArray);
		//System.out.println(sameFirstLast(setArray));
		int a [] =  {1, 2, 3};
		int b [] = {7, 5};	
		commonEnd(a, b);
		System.out.println(commonEnd(a, b));
		
	}
	
	//exercise 1
	/*public static boolean firstLast(int i[]) {
		if (i[0] == 6 || i[i.length - 1] == 6) {
			return true;
		}
		else {
			return false;
		}
	}*/
	
	//exercise 2
	/*public static boolean sameFirstLast (int[] i) {
		//compares the first number at index 0 to last number at end of array (i.length). -1 is used to prevent going off rails
		if ((i[0] == i[i.length - 1]) && (i.length > 1)) {
			return true;
		}
		else {
			return false;
		}
	}*/
	
	//Exercise 3
	public static boolean  commonEnd(int a[], int b[]){
		if ((a[0] == b[0] || a[a.length - 1] == b[b.length - 1]) && (a.length > 1 && b.length > 1)) {
			return true;
		}
		else {
			return false;
		}
	}

}
