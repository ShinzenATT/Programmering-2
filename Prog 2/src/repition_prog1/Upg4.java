package repition_prog1;

import java.util.Scanner;

public class Upg4 {
	public static int smallest(int a, int b) {
		if(a > b) {
			return b;
		}
		
		else {
			return a;
		}
	}
	
	public static void main(String[] args) {
			Scanner input = new Scanner(System.in);
			System.out.println("Ange 2 siffror");
			int first = input.nextInt();
			int second = input.nextInt();
			input.close();
			System.out.println("Minsta: " + smallest(first, second));
			
		}
}
