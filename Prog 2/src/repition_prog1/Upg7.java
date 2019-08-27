package repition_prog1;

import java.util.Scanner;

public class Upg7 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Ange ett tal");
		int test = input.nextInt();
		input.close();
		boolean isPrime = true;
		// System.out.println(Math.sqrt(test));
		if(test == 2) {
			isPrime = false;
		}
		else {
			for (int i = 2; i <= Math.sqrt(test); i++) {
				if(test%i == 0) {
					isPrime = false;
					// System.out.println(i + " " + test%i + " " + test/i);
					break;
				}
			}
		}
		
		if(isPrime) {
			System.out.println(test + " är ett primtal");
		}
		else {
			System.out.println(test + " är inte ett primtal");
		}
	}
}
