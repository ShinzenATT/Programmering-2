package repitition2;

public class Upg6 {
    public static void main(String[] args) {
        anagram("god dag");
    }

    public static void anagram(String target){
        if (target.length() > 0){
            char[] letters = target.toCharArray();
            int index = (int) (Math.random() * letters.length);
            System.out.print(letters[index]);

            String temp = "";
            for (int i = 0; i < letters.length; i++) {
                if(i != index){
                    temp+= letters[i];
                }
            }
            anagram(temp);
        }
    }
}
