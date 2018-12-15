# Be.Vlaanderen.Basisregisters.AspNetCore.Mvc.Middleware.AddCorrelationIdToResponse

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
