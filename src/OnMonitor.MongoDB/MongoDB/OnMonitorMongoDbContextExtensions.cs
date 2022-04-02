using Volo.Abp;
using Volo.Abp.MongoDB;

namespace OnMonitor.MongoDB;

public static class OnMonitorMongoDbContextExtensions
{
    public static void ConfigureOnMonitor(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
