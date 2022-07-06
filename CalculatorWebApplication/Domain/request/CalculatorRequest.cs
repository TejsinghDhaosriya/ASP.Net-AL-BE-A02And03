namespace CalculatorWebApplication.Domain.request
{
    public class CalculatorRequest
    {
        public CalculatorRequest()
        {
        }

        public CalculatorRequest(double firstNumber, double lastNumber)
        {
          this.FirstNumber = firstNumber;
          this.LastNumber = lastNumber;
        }

        public double FirstNumber { get; set; }

        public double LastNumber { get; set; }
    }

}
