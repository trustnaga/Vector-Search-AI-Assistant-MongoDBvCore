using Microsoft.Extensions.Logging;

namespace SharedLib.Options
{
    public record DataStorage
    {
        public string? ConnectionUrl { get; set; }

        public string? ContainerName { get; set; }

        public required ILogger Logger { get; init; }
    }
}
