using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace migrate_to_asp_net
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("MiddleWare from FILE USE\n");
            await next(context);
            await context.Response.WriteAsync("MiddleWare from FILE USE 2\n");
        }
    }
}
