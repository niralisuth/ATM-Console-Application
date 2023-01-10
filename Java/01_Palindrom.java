package primeNumber;

import java.util.Scanner;

public class PM {

	public static void main(String[] args) {
				
			try (Scanner sc = new Scanner(System.in)) {
				int n,rev =0, p;
				
				System.out.println("Enter a number : ");
				
				 n = sc.nextInt();
				p = n;
				
				while(n>0) {
					rev = (rev*10)+(n%10);
					n = n/10;
				}
				
				if (rev == p) {
					System.out.println( " It is a palindrom Number");
				}
				else {
					System.out.println(" Not a palindrom Number");
				}
			}
	}
}