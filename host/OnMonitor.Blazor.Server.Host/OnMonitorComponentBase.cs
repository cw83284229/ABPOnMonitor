using OnMonitor.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OnMonitor.Blazor.Server.Host;

public abstract class OnMonitorComponentBase : AbpComponentBase
{
    protected OnMonitorComponentBase()
    {
        LocalizationResource = typeof(OnMonitorResource);
    }
}
