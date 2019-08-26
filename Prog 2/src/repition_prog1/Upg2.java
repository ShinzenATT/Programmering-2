package repition_prog1;

import java.util.Scanner;

public class Upg2 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Write 3 words.");
		String[] words = new String[3];
		for (int i = 0; i < 3; i++) {
			words[i] = input.next();
		}
		input.close();
		String output = "";
		for (int i = words.length - 1; i >= 0; i--) {
			output += words[i] + " ";
		}
		System.out.println(output);
	}
}
