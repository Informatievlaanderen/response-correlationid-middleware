namespace Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware.AddCorrelationIdToResponse.Tests
{
    using System.Reflection;
    using System.Threading.Tasks;
    using FluentAssertions;
    using Microsoft.AspNetCore.Http;
    using Xunit;

    public class AddCorrelationIdToResponseMiddlewareTests
    {
        [Fact]
        public async Task AddsCorrelationIdToDefaultResponseHeaders()
        {
            var middleware = new AddCorrelationIdToResponseMiddleware(innerContext => Task.CompletedTask);
            var context = new DefaultHttpContext();

            await middleware.Invoke(context);

            context.Response.Headers.ContainsKey(AddCorrelationIdToResponseMiddleware.HeaderName).Should().BeTrue();
            //context.Response.Headers[AddCorrelationIdToResponseMiddleware.HeaderName].Should().BeEquivalentTo(expectedVersion);
        }

        [Fact]
        public async Task AddsCorrelationIdToResponseHeaders()
        {
            var headerName = "x-corrrrrrrr";
            var middleware = new AddCorrelationIdToResponseMiddleware(innerContext => Task.CompletedTask, headerName);
            var context = new DefaultHttpContext();

            await middleware.Invoke(context);

            context.Response.Headers.ContainsKey(headerName).Should().BeTrue();
            //context.Response.Headers[headerName].Should().BeEquivalentTo(expectedVersion);
        }
    }
}
