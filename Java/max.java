package primeNumber;

import java.util.Scanner;

public class PM {

	public static void main(String[] args) {
		
		//For 2 Numbers
		
		
	Scanner sc = new Scanner(System.in);
		
	System.out.println("Enter 1st Number : ");
		int a = sc.nextInt();	
	System.out.println("Enter 2nd Number");
	int b = sc.nextInt();
		
		if(a>b) {
			System.out.println(a+ " is max number");
	}
		
		else {
			System.out.println(b + " is max number");
		}
		
		
		// for 3 numbers
		int e,f,c;
		Scanner scc = new Scanner(System.in);
		System.out.println("Enter 1st Number: ");
		e=scc.nextInt();
		System.out.println("Enter 2nd number: ");
		f=scc.nextInt();
		System.out.println("Enter 3rd Number: ");
		c=scc.nextInt();
		
		if(e>f&&e>c){
			System.out.println(e + " is a max number");
			
		}
		else if (f>e && f>c) {
			System.out.println(f + " is a max number");
		}
		
		else {
			System.out.println(c+ " is a max number");
		}
	}
}
