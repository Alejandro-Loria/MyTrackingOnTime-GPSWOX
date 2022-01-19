using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MyTrackingOnTime.Filters
{
    public class UseStopwatchAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Stopwatch stopWatch = new();
            stopWatch.Start();
            if (filterContext.Controller is Controller Controller)
            {
                Controller.ViewData["stopWatch"] = stopWatch;
                Controller.ViewBag.stopWatch = stopWatch;
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Controller is Controller Controller)
            {
                Stopwatch stopWatch = (Stopwatch)Controller.ViewBag.stopWatch;
                stopWatch.Stop();

                double et = stopWatch.Elapsed.Seconds +
                   (stopWatch.Elapsed.Milliseconds / 1000.0);

                Controller.ViewBag.elapsedTime = et.ToString();
            }
        }
    }
}
