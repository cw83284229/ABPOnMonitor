using Tchivs.Abp.AspNetCore.Blazor.Theme.Bootstrap;
using Volo.Abp.Modularity;

namespace OnMonitor.Blazor.WebAssembly;

[DependsOn(
    typeof(OnMonitorBlazorModule),
    typeof(OnMonitorHttpApiClientModule),
    typeof(AbpAspNetCoreBlazorThemeBootstrapWebAssemblyModule)
    )]
public class OnMonitorBlazorWebAssemblyModule : AbpModule
{

}
