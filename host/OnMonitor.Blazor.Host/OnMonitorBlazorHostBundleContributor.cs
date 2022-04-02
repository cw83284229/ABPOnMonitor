using Volo.Abp.Bundling;

namespace OnMonitor.Blazor.Host;

public class OnMonitorBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
