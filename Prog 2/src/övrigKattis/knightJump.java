package övrigKattis;

import java.util.Scanner;

public class knightJump {

    boolean[][] field;
    boolean[][] trackFresh;
    static boolean success = false;

    static int MinSteps = -1;
    int N = 0;
    int[] knightStart = new int[2];

    static final int[] rDirections = {-2, -1, -2, 1, 2, 1, -1, 2};
    static final int[] cDirections = {-1, -2, 1, -2, -1, 2, 2, 1};

    public knightJump(int n, String[] rows){

        N = n;

        field = new boolean[N][N];
        trackFresh = new boolean[N][N];

        for (int i = 0; i < N; i++) {

            String temp = rows[i];

            for (int j = 0; j < N; j++) {

                if (temp.charAt(j) == '.') {
                    field[j][i] = true;
                } else if (temp.charAt(j) == '#') {
                    field[j][i] = false;
                    // System.out.println("#" + j + " " + i);
                } else if (temp.charAt(j) == 'K') {
                    field[j][i] = false;
                    knightStart[0] = j;
                    knightStart[1] = i;
                    // System.out.println("K" + j + " " + i);
                }

                trackFresh[j][i] = true;

            }
        }
    }


    private int travel(int r, int c, int steps, boolean[][] track, String journey) {
        //System.out.print(r + ", " + c + " > ");
        String progress = journey  + (r + 1) + "," + (c + 1) + " > ";
        if (r == 0 && c == 0) {
            if(success && steps < MinSteps){
                MinSteps = steps;
            }
            else{
                success = true;
                MinSteps = steps;
            }

        } else {
            for (int i = 0; i < rDirections.length; i++) {
                int rd = r + rDirections[i];
                int cd = c + cDirections[i];
                if (N > rd && rd >= 0 && N > cd && cd >= 0 && field[rd][cd] && track[rd][cd]) {
                    track[rd][cd] = false;
                    System.out.println((r+1) + "," + (c+1) + " -> " + (r + rDirections[i] + 1) + "," + (c + cDirections[i] +1) + "  (" + rDirections[i] + "," + cDirections[i] + ")");
                    travel(rd, cd, steps + 1, track, progress);
                }
            }

        }
        //System.out.println("end. Steps: " + steps);
        System.out.println();
        if(r == 0 && c == 0){
            progress = journey + "1,1 success ";
        }
        System.out.println(progress + "end Steps: " + steps);
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if(!(field[j][i])){
                    System.out.print("#");
                }
                else if(!(track[j][i])){
                    System.out.print("X");
                }
                else{
                    System.out.print(".");
                }
            }
            System.out.println();
        }
        System.out.println();
        return MinSteps;
    }

    public int travelStart(){
        return travel(knightStart[0], knightStart[1], 0, trackFresh, "");
    }

}

class test{
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        String[] rows = new String[n];
        for (int i = 0; i < n; i++) {
            rows[i] = input.next();
        }
        input.close();

        knightJump kj = new knightJump(n, rows);

        System.out.println(kj.travelStart());
    }
}


