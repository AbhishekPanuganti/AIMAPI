using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLLCOMMONAPI.Models;
using System;

namespace NLLCOMMONAPI.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {

            var error = new ExceptionModel
            {
                Message = context.Exception.Message,
                StatusCode = "500"
            };

            //var result = JsonSerializer.Serialize(new
            //{
            //    message = exception.Message,
            //    statusCode,
            //    detail = exception.StackTrace // Remove this in production for security
            //});

            context.Result = new JsonResult(error) { StatusCode = 500 };
        }
    }
}
