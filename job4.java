import java.util.Scanner; 

public class job4 {

    public static double Name(double a, double b, double c) {
        return Math.sqrt(b * c * Math.pow(b + c, 2) - Math.pow(a, 2)) / (b + c);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in, "UTF-8");

        double a = 4;
        double b = 6;
        double c = 5;

        double result = Name(a, b, c);

        System.out.println(result);  

        scanner.close();
    }
}