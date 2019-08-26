package repition_prog1;

import java.util.Scanner;
import java.util.ArrayList;

public class Upg1 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		ArrayList<Integer> arr = new ArrayList<Integer>();
		System.out.println("Write 0 to stop.");
		while(true) {
			int query = input.nextInt();
			if(query == 0) {
				break;
			}
			else {
				arr.add(query);
			}
		}
		
		int result = 0;
		for (int i = 0; i < arr.size(); i++) {
			result+= arr.get(i);
		}
		
		System.out.println("Sum: " + result);
		
		input.close();
	}
}
