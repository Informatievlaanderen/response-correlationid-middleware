namespace Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Add an 'x-correlation-id' header to all responses.
    /// </summary>
    public class AddCorrelationIdToResponseMiddleware
    {
        public const string HeaderName = "x-correlation-id";

        private readonly RequestDelegate _next;
        private readonly string _headerName;

        public AddCorrelationIdToResponseMiddleware(
            RequestDelegate next,
            string headerName = HeaderName)
        {
            _next = next;
            _headerName = headerName;
        }

        public Task Invoke(HttpContext context)
        {
            context
                .Response
                .Headers
                .Add(_headerName, context.TraceIdentifier);

            return _next(context);
        }
    }
}
