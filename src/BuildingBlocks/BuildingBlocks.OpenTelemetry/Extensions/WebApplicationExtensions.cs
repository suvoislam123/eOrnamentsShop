using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpenTelemetry.Metrics;   

namespace BuildingBlocks.OpenTelemetry.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication MapDefaultOpenTelemetry(this WebApplication app)
    {
        var options = app.Services.GetRequiredService<IOptions<OpenTelemetryOptions>>().Value;

        if (options.UsePrometheusExporter)
        {
            app.MapPrometheusScrapingEndpoint();
        }

        return app;
    }
}