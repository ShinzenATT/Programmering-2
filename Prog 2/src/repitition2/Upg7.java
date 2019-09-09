package repitition2;

import java.util.ArrayList;

public class Upg7 {
    ArrayList<Integer> numbers = new ArrayList<>();
    final static char space = ' ';

    public Upg7(int maxAmount){
        numbers.add(1);
        if(maxAmount >= 2) {
            numbers.add(1);
        }
        generateSequence(maxAmount - 2, 1, 1);

    }

    private void generateSequence(int i, int a, int b){
        if(i > 0){
            numbers.add(a+b);
            // System.out.print((a+b) + " ");
            generateSequence(--i, b, a+b);
        }
    }

    public void draw(){

    }


}

class test2 {
    public static void main(String[] args) {
        Upg7 test = new Upg7(12);
    }
}
