using CalculatorWebApplication.Domain.request;
using CalculatorWebApplication.Domain.response;
using CalculatorWebApplication.Filter;
using CalculatorWebApplication.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApplication.Controllers
{
    [ApiController]
    [Route("/api")]
    public class CalculatorController : Controller
    {

        private readonly IMath _math;

        public CalculatorController(IMath math)
        {
            _math = math;
        }

        [HttpPost]
        [Route("/add")]
        public CalculatorResponse Addition([FromBody] CalculatorRequest req)
        {
            try
            {
                var response = _math.Add(req.FirstNumber,req.LastNumber);
                return new CalculatorResponse(response,null);
            }
            catch(Exception ex)
            {
                return new CalculatorResponse(null,ex.Message);
            }
        }

        [HttpPost]
        [Route("/subtract")]
        public CalculatorResponse Subtraction([FromBody] CalculatorRequest req)
        {
            try
            {
                var response = _math.Subtract(req.FirstNumber, req.LastNumber);
                return new CalculatorResponse(response, null);
            }
            catch (Exception ex)
            {
                return new CalculatorResponse(null, ex.Message);
            }
        }

        [HttpPost]
        [Route("/multiplication")]
        public CalculatorResponse Multiplication([FromBody] CalculatorRequest req)
        {
            try
            {
                var response = _math.Multiply(req.FirstNumber, req.LastNumber);
                return new CalculatorResponse(response, null);
            }
            catch (Exception ex)
            {
                return new CalculatorResponse(null, ex.Message);
            }
        }

        [ServiceFilter(typeof(ValidateCalculateRequestFilter))]
        [HttpPost]
        [Route("/divide")]
        public CalculatorResponse Division([FromBody] CalculatorRequest req)
        {
            try
            {
                var response = _math.Divide(req.FirstNumber, req.LastNumber);
                return new CalculatorResponse(response, null);
            }
            catch (Exception ex)
            {
                return new CalculatorResponse(null, ex.Message);
            }
        }
    }
}
