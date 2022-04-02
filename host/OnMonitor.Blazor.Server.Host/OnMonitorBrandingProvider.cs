using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OnMonitor.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class OnMonitorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OnMonitor";
}
