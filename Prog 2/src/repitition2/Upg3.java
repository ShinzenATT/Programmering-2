package repitition2;

public class Upg3 {
    public static <T> T[] object2array (T... args){
        /*
        for (int i = 0; i < args.length; i++) {
            System.out.println(args[i].toString());
        } */
        return args;
    }

    /* public static void main(String[] args) {
        object2array(new Scanner(System.in), 10, "Nope");
    } */
}
