package repitition2;

import java.util.Scanner;

public class Upg2 {
    public static  void backward(String query){
        backward(query, query.length()-1);
    }

    public static void backward( String query, int i){
        if(i >= 0) {
            System.out.print(query.charAt(i));
            backward(query, --i);
        }
    }

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Skriv en mening och avsluat med att trycka på enter.");
        backward(input.nextLine());
        input.close();
    }
}
