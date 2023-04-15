using WebApp.Interfaces;
using WebApp.Services;

namespace WebApp.Classes
{
    public class CounterMiddleware
    {
        RequestDelegate next;
        int i = 0;

        public CounterMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, ICounter counter, CounterService counterService)
        {
            i++;
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"Request {i}; Counter: {counter.Count}; Service: {counterService.Counter.Count}");
        }
    }
}
