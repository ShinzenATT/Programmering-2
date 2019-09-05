package repitition2;

import java.awt.*;

public class Box{

   Object[] obj;

    public Box(Object... objects){
        obj = objects;
    }

    public Object[] getArray(){
        return obj;
    }

    public boolean compare(Object[] a, Object[] b){

        boolean isSimilar = false;

        for (int i = 0; i < a.length; i++) {
            for (int j = 0; j < b.length; j++) {
                if(a[i].getClass().equals(b[j].getClass())){
                    isSimilar = true;
                    System.out.println(a[i].toString() + " - " + b[j].toString());
                    break;
                }
            }
        }
         return  isSimilar;
    }

    public boolean compare(Box b){
        return compare(obj, b.getArray());
    }



    public boolean compare(Box a, Box b){
        return compare(a.getArray(), b.getArray());
    }

}

class  test{
    public static void main(String[] args) {
        Box a = new Box("Stuff", new Rectangle(10,15));
        Box b = new Box( new Rectangle(), 10);

        System.out.println(a.compare(b));
    }
}
