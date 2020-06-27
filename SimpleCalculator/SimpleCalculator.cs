using System;
public class SimpleCalculator{
    public static void Main(String [] args){
        double result = 0, n1 = 0, n2 = 0;
        bool repeat = true;
        char sign = ' ';
        do{
            Console.Write("Enter the first number: ");
            try{
                n1 = Convert.ToDouble(Console.ReadLine());
                repeat = false;
            }catch(Exception e){
                Console.WriteLine("Invalid value!");
            }
        }while(repeat);
        repeat = true;
        while(true){
            Console.Write("Enter the sign( + , - , * , / ): ");
            sign = Convert.ToChar(Console.ReadLine().Trim());
            if("+-*/".Contains(sign.ToString())){
                break;
            }
            Console.WriteLine("Invalid value!");
        }
        do{
            Console.Write("Enter the second number: ");
            try{
                n2 = Convert.ToDouble(Console.ReadLine());
                repeat = false;
            }catch(Exception e){
                Console.WriteLine("Invalid value!");
            }
        }while(repeat);
        if(sign == '+'){
            result = n1 + n2;
        }else if(sign == '-'){
            result = n1 - n2;
        }else if(sign == '*'){
            result = n1 * n2;
        }else if(sign == '/'){
            result = n1 / n2;
        }
        Console.WriteLine(String.Format("{0} {1} {2} = {3}", n1, sign, n2, result));
    }
}
