using NLLCOMMONAPI.Models;
using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;


namespace NLLCOMMONAPI.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
      

        public async Task InvokeAsync(HttpContext context, Mdmdbcontext _dbcontext)
        {
            try
            {
                await _next(context); // Proceed to the next middleware
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred.");
                await HandleExceptionAsync(context, ex, _dbcontext); // Handle exceptions globally
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception, Mdmdbcontext _dbcontext)
        {
            string requestpath = context.Request.Path;
            // Log the exception if needed (e.g., use ILogger)
            var response = context.Response;
            response.ContentType = "application/json";
            // Customize error response based on exception type
            var statusCode = exception switch
            {
                KeyNotFoundException => (int)HttpStatusCode.NotFound,
                UnauthorizedAccessException => (int)HttpStatusCode.Unauthorized,
                _ => (int)HttpStatusCode.InternalServerError
            };

            response.StatusCode = statusCode;

            var error =  new ExceptionModel
            {
                Message = exception.Message,
                StatusCode = statusCode.ToString()
            };


            string? userid = null;
            string? username = null;
            var user = context.User;
            if (user != null)
            {
                userid = user.FindFirst("globalid")?.Value;
                username = user.FindFirst(JwtRegisteredClaimNames.Name)?.Value;
            }
            var exlog = new ExceptionlogModel
            {
                id = 0,
                userid = userid ?? string.Empty,
                username = username ?? string.Empty,
                apipath = requestpath,
                exeptiontext = exception.Message
            };

           await _dbcontext.SaveExceptionLog(exlog);

            //var result = JsonSerializer.Serialize(new
            //{
            //    message = exception.Message,
            //    statusCode,
            //    detail = exception.StackTrace // Remove this in production for security
            //});

            await response.WriteAsync(error.ToString());
        }
    }
}
