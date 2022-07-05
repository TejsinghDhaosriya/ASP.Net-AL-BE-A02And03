using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApplication.Domain.request
{
    public class CalculatorRequest
    {
        public CalculatorRequest()
        {
        }

        public double FirstNumber { get; set; }
        public double LastNumber { get; set; }
    }

}
