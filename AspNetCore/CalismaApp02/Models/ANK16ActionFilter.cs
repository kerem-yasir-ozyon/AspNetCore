using Microsoft.AspNetCore.Mvc.Filters;

namespace CalismaApp02.Models
{
    public class ANK16ActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sonra");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Once");
        }
    }
}
