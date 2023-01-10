package primeNumber;

import java.util.Scanner;

public class PM {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int n,i,sum=0;
		
		System.out.println("Enter the value of N: ");
		
		n = sc.nextInt();
		i = 1;
		
		while(i<=n) {
			sum = sum + n;
			i++;
		}
		
		System.out.println("Addition of natural numbers: " + sum);
		
	
			
				}
			
	}
