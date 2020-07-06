package quadraticEquation;

public class QuadraticEquation {
    private double delta, x1, x2;
    private String sDelta, sResult;
    public QuadraticEquation(double a, double b, double c){
        if(a == 0){
            sDelta = "Δ : ";
            sResult = "Result : It's not a Quadratic Equation";
        }else{
            delta = Math.pow(b, 2) - (4 * a * c);
            sDelta = "Δ : " + delta;
            if(delta < 0){
                sResult = "Result : Delta < 0";
            }else{
                x1 = (- b + Math.sqrt(delta))/(2 * a);
                x2 = (- b - Math.sqrt(delta))/(2 * a);
                sResult = String.format("Result : X1 = %.5f; X2 = %.5f", x1, x2);
            }
        }
    }

    public String getSDelta(){
        return sDelta;
    }
    public String getSResult(){
        return sResult;
    }
}
