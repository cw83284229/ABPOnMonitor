using OnMonitor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OnMonitor;

public abstract class OnMonitorController : AbpControllerBase
{
    protected OnMonitorController()
    {
        LocalizationResource = typeof(OnMonitorResource);
    }
}
