﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace OlayaDigital.Infrastructure.Filters
{
    /*Esta validación es para mirar si todos los modelos estan entrando correctamente*/
    public class ValidationFilter : IAsyncActionFilter
    {
        /*OnActionExecutionAsync = Se ejecuta cuando se invoque el requist hacia los controladores*/
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
                return;
            }

            await next();
        }
    }
}
