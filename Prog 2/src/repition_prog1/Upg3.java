package repition_prog1;

import java.util.Scanner;

public class Upg3 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Ange en cirkels radie.");
		double radius = input.nextDouble();
		System.out.println("Volym på en sphär: " + (4.0/3.0)*Math.PI*Math.pow(radius, 3));
		input.close();
	}
}
