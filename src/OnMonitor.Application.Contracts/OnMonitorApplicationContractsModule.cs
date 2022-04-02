using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace OnMonitor;

[DependsOn(
    typeof(OnMonitorDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class OnMonitorApplicationContractsModule : AbpModule
{

}
