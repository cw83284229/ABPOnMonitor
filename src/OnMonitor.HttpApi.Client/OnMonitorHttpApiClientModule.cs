using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace OnMonitor;

[DependsOn(
    typeof(OnMonitorApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class OnMonitorHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(OnMonitorApplicationContractsModule).Assembly,
            OnMonitorRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OnMonitorHttpApiClientModule>();
        });

    }
}
