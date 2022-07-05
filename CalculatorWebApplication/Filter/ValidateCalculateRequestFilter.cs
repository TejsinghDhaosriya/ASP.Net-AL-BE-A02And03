using CalculatorWebApplication.Domain.request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CalculatorWebApplication.Filter
{
    public class ValidateCalculateRequestFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            {
                var req = context.ActionArguments["req"] as CalculatorRequest;
     
                if (req!.FirstNumber <=0 || req.LastNumber <=0)
                {
                    context.HttpContext.Response.StatusCode = 400;
                    context.Result = new ContentResult()
                    {
                        Content = "Divident/Divisor should be greater than zero"
                    };
                    return;
                }

                base.OnActionExecuting(context);
            }
        }
    }
}