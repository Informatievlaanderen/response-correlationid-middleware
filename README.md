# Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware.AddCorrelationIdToResponse [![Build Status](https://github.com/Informatievlaanderen/response-correlationid-middleware/workflows/CI/badge.svg)](https://github.com/Informatievlaanderen/response-correlationid-middleware/actions)

Middleware component which adds the correlation id to the response as header `x-correlation-id`.

## Usage

```csharp
public void Configure(IApplicationBuilder app, ...)
{
    app
        ...
        .UseMiddleware<AddCorrelationIdToLogContextMiddleware>()
        .UseMiddleware<AddCorrelationIdToResponseMiddleware>()
        .UseMiddleware<AddCorrelationIdMiddleware>()
        ...
}
```
