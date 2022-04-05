using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OnMonitor.EntityFrameworkCore;

[DependsOn(
    typeof(OnMonitorDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class OnMonitorEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<OnMonitorDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            //Autofac反射设定
            //默认情况下，这将为每个聚合根实体（从派生的类AggregateRoot）创建一个存储库。如果您也想为其他实体创建存储库，请设置includeAllEntities为true：
            //参考https://docs.abp.io/en/abp/latest/Entity-Framework-Core#add-default-repositories
            options.AddDefaultRepositories(includeAllEntities: true);//
        });
    }
}
