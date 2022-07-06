using CalculatorWebApplication.Service.Interface;

namespace CalculatorWebApplication.Service.Impl
{
    public class MathService : IMathService
    {
        public double Add(double number, double number2) => number + number2;

        public double Subtract(double number, double number2) => number - number2;

        public double Multiply(params double[] numbers) =>
            numbers.Aggregate<double, double>(1, (current, number) => current * number);

        public double Divide(double number, double number2) => number / number2;
    }
}
