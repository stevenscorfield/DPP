package Arrays;

public class exercise5 {
	public static void main(String[] args){
		int a [] =  {2,2};	
		int check1 [];
		check1 = new int [2];
		int check2 [];
		check2 = new int [3];
		commonEnd(a);
		System.out.println(commonEnd(a));
	}

	public static boolean  commonEnd(int a[]){
		if ((a[0] == 2 || a[a.length - 1] == 2) ||(a[0] == 3 || a[a.length - 1] == 3) && a.length >=2) {
			return true;
		}
		else {
			return false;
		}
	}

}
