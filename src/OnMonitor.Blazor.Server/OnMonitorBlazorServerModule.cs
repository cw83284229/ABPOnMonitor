using Tchivs.Abp.AspNetCore.Blazor.Theme.Bootstrap;
using Volo.Abp.Modularity;

namespace OnMonitor.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreBlazorThemeBootstrapServerModule),
    typeof(OnMonitorBlazorModule)
    )]
public class OnMonitorBlazorServerModule : AbpModule
{

}
