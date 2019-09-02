package repitition2;;

public class Upg1 {

    public static int sum (int... term){

        int sum = 0;
        for (int i = 0; i < term.length ; i++) {
            sum+= term[i];
        }
        return sum;
    }
}
