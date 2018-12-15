namespace Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Add an 'x-correlation-id' header to all responses.
    /// </summary>
    public class AddCorrelationIdToResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public const string HeaderName = "x-correlation-id";

        public AddCorrelationIdToResponseMiddleware(RequestDelegate next) => _next = next;

        public Task Invoke(HttpContext context)
        {
            context
                .Response
                .Headers
                .Add(HeaderName, context.TraceIdentifier);

            return _next(context);
        }
    }
}
