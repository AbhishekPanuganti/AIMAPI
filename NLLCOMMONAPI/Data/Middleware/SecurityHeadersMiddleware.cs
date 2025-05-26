namespace NLLCOMMONAPI.Data.Middleware
{
    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Add Content Security Policy (CSP)
            context.Response.Headers.Append("Content-Security-Policy", "default-src 'self';");

            // Add X-Content-Type-Options
            context.Response.Headers.Append("X-Content-Type-Options", "nosniff");

            // Add X-Frame-Options
            context.Response.Headers.Append("X-Frame-Options", "DENY");

            // Add Referrer-Policy
            context.Response.Headers.Append("Referrer-Policy", "no-referrer");

            // Add X-XSS-Protection
            context.Response.Headers.Append("X-XSS-Protection", "1; mode=block");
            //context.Response.Headers.Remove("X-Powered-By");
            //context.Response.Headers.Remove("server");


            // Add Strict-Transport-Security (HSTS)
            if (context.Request.IsHttps)
            {
                context.Response.Headers.Append("Strict-Transport-Security", "max-age=31536000; includeSubDomains");
            }

            await _next(context);
        }
    }
}
