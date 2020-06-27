import java.util.Scanner;
public class SimpleCalculator{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double result = 0,  n1 = 0, n2 = 0;
        char sign = ' ';
        boolean repeat = true;
        do{
            System.out.print("Enter the first number: ");
            try{
                n1 = sc.nextDouble();
                repeat = false;
            }catch(Exception e){
                sc.nextLine();
                System.out.println("Invalid value!");
            }
        }while(repeat);
        repeat = true;
        while(true){
            System.out.print("Enter the sign( + , - , * , / ): ");
            sign = sc.next().strip().charAt(0);
            if("+-*/".contains(Character.toString(sign))){
                break;
            }
            System.out.println("Invalid value!");
        }
        do{
            System.out.print("Enter the second number: ");
            try{
                n2 = sc.nextDouble();
                repeat = false;
            }catch(Exception e){
                sc.nextLine();
                System.out.println("Invalid value!");
            }
        }while(repeat);
        if(sign == '+'){
            result = n1 + n2;
        } else if(sign == '-'){
            result = n1 - n2;
        } else if(sign == '*'){
            result = n1 * n2;
        } else if(sign == '/'){
            result = n1 / n2;
        }
        System.out.println(String.format("%.2f %c %.2f = %.2f", n1, sign, n2, result));
        sc.close();
    }
}
