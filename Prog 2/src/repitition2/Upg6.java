package repitition2;

import java.util.ArrayList;

public class Upg6 {
    static ArrayList<String> anagrams = new ArrayList<>();

    public static void main(String[] args) {
        anagram("why");
    }

    public static void anagram(String target) {

        String temp = "";
        ArrayList<Integer> usedChars = new ArrayList<>();

        for (int i = 0; i < target.length(); i++) {

            char[] letters = target.toCharArray();
            int index;
            do {
                index = (int) (Math.random() * letters.length);
            } while (usedChars.contains(index));

            temp += letters[index];
            usedChars.add(index);

        }

        if (anagrams.size() < Math.pow(target.length(), 2) - 1) {
            if (!(anagrams.contains(temp) || temp == target)) {
                anagrams.add(target);
                System.out.println(temp);
            }

            anagram(target);
        }

    }
}
