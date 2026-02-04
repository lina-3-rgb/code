import java.util.Scanner; 

public class job2 {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in, "UTF-8");

        System.out.print("Введите x: ");
        double x = scanner.nextDouble();
        System.out.print("Введите y: ");
        double y = scanner.nextDouble();
        System.out.print("Введите a: ");
        double a = scanner.nextDouble();
        System.out.print("Введите b: ");
        double b = scanner.nextDouble();
       
        double z ;

        if (x > 0 && y > 0) {
    double maxEl = a / x;
    if (maxEl < b / x) {
        maxEl = b / x;
    }
    if (maxEl < Math.sqrt(y)) {
        maxEl = Math.sqrt(y);
    }
    z = maxEl;
} else if (x < 0 && y > 0) {
    double minEl = a * Math.pow(x, 3);
    if (minEl < b * Math.pow(y, 2));
        minEl = b * Math.pow(y, 2);
    z = minEl;
} else z = Math.pow(2, x + y);
        
    
     System.out.println("Ваше число: " + z);
        
        scanner.close();
    }
}