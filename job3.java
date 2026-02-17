import java.util.Scanner; 

public class job3 {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in, "UTF-8");

System.out.print("Введите x: ");
        double x = scanner.nextDouble();
     for (double i =-3; i<3;i+=0.25){
    if(x>2){
        x= Math.pow(Math.E,2);
    }else if (i>=-2 && i<=2){
        x=x+4;
    } else {
        x=0;
    }
}
System.out.println("Ваше число: " + x);
        
        scanner.close();
    }
}
