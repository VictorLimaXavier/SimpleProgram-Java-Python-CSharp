import java.util.Scanner;
public class Hello{
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Whats is your name?");
        String name = sc.nextLine();
        System.out.println("Hello " + name);
        sc.close();
    }
}