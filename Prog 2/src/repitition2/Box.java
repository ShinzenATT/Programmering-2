package repitition2;

import java.awt.*;

public class Box<T>{

    T[] obj;

    public Box(T... objects){
        obj = objects;
    }

    public T[] getArray(){
        return obj;
    }

    public boolean compare(T[] a, T[] b){

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
        return compare(obj, (T[]) b.getArray());
    }



    public boolean compare(Box a, Box b){
        return compare((T[]) a.getArray(), (T[]) b.getArray());
    }

}

class  test{
    public static void main(String[] args) {
        Box a = new Box("Stuff", new Rectangle(10,15));
        Box b = new Box( new Rectangle(), 10);

        System.out.println(a.compare(b));
    }
}
