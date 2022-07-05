namespace CalculatorWebApplication.Service.Interface
{
    public interface IMath
    {

        double Add(double number, double number2);
        double Subtract(double number, double number2);
        double Multiply(params double[] numbers);
        double Divide(double number, double number2);
    }
}
