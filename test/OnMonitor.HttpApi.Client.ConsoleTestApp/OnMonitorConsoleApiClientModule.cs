using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace OnMonitor;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OnMonitorHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class OnMonitorConsoleApiClientModule : AbpModule
{

}
