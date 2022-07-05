namespace CalculatorWebApplication.Domain.response
{
    public class CalculatorResponse
    {
    
        public CalculatorResponse(double? data, string? error)
        {
            Data = data;
            Error = error;
        }
     
        public double? Data { get;  }
        public string? Error { get; }
    }
}
