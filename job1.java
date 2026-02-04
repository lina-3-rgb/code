import java.util.Scanner; 

public class job1 {
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in, "UTF-8");

        System.out.print("Введите x: ");
        double x = scanner.nextDouble();
        System.out.print("Введите y: ");
        double y = scanner.nextDouble();
    
    double d =  Math.pow((y * Math.pow(x, 2) - 1), 2) / (2) * (Math.pow(Math.cos(y), 2) - Math.sin(Math.pow(x,2)));
    
    System.out.println("Ваше число: " + d);
        
        scanner.close();
    }


}
