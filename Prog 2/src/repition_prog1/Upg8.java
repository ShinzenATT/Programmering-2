package repition_prog1;

import java.util.ArrayList;
import java.util.Scanner;

public class Upg8 {
	
	public static int[] sort(int[] sortArr) {
		for(int i = 0; i < sortArr.length - 1; i++) {
			int tempIndex = i;
			for(int j = i; j < sortArr.length ; j++) {
				if(j == i || sortArr[tempIndex] > sortArr[j]) {
					tempIndex = j;
				}
			}
			int temp = sortArr[i];
			sortArr[i] = sortArr[tempIndex];
			sortArr[tempIndex] = temp;
		}
		return sortArr;
	}
	
	public static int[] inputAndSort(){
		Scanner input = new Scanner(System.in);
		System.out.println("Skriv in flera tal och avlsuta med 0.");
		ArrayList<Integer> list = new ArrayList<Integer>();
		while(true) {
			int temp = input.nextInt();
			if(temp == 0) {
				break;
			}
				list.add(temp);
		}
		input.close();
		int[] array = new int[list.size()];
		for (int i = 0; i < array.length; i++) {
			array[i] = list.get(i);
		}
		return sort(array);
	}
	
	public static void main(String[] args) {
		int[] result = inputAndSort();
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
	}
}
