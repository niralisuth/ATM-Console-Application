package primeNumber;

import java.util.Scanner;

public class PM {

	public static void main(String[] args) {
				
				Scanner num = new Scanner(System.in);
				System.out.println("Enter a Number : ");
				
				int n = num.nextInt();
				
				if (isPrime(n)) {
					System.out.println(n + " Is a prime Number");
				}
				
				else {
					System.out.println(n + " Is not a prime Number");
				}
				
				}
			
			public static boolean isPrime(int n) {
				if( n<=1) {
					return false;
				}
				for (int i = 2 ; i<Math.sqrt(n); i++) {
				if(n%i ==0) {
					return false;
				}
				}
				
				return true;
				
			}
			

		


	}
