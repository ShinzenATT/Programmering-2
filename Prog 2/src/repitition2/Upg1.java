package repitition2;

import java.util.ArrayList;
import java.util.Scanner;

public class Upg1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        ArrayList<Integer> term = new ArrayList<Integer>();
        System.out.println("Skriv tal som ska summeras och avsluta med 0.");
        while (true){
            int temp = input.nextInt();
            if(temp == 0){
                break;
            }
            else{
                term.add(temp);
            }
        }
        int sum = 0;
        for (int i = 0; i < term.size() ; i++) {
            sum+= term.get(i);
        }
        System.out.println("Summa: " + sum);
    }
}
