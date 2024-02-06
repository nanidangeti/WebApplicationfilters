using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace WebApplicationfilters.Controllers
{
    public class EmployeeController : Controller,IActionFilter
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Called before the action executes, after model binding is complete.
        /// </summary>
        /// <param name="context">The <see cref="ActionExecutingContext"/>.</param>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("I am Executing after the action result");
        }
                     
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("I am Executing before the action result");
        }

    }
}
