using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace OnMonitor.Blazor.Menus;

public class OnMonitorMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(OnMonitorMenus.Prefix, displayName: "OnMonitor", "/OnMonitor", icon: "fa fa-globe"));
        context.Menu.AddItem(new ApplicationMenuItem(OnMonitorMenus.Prefix, displayName: "监控室", "/OnMonitor/1", icon: "fa fa-globe"));
        context.Menu.AddItem(new ApplicationMenuItem(OnMonitorMenus.Prefix, displayName: "真实监控室", "/Equiment/MonitorRoom", icon: "fa fa-globe"));
        context.Menu.AddItem(new ApplicationMenuItem(OnMonitorMenus.Prefix, displayName: "OnMonitor", "/OnMonitor/3", icon: "fa fa-globe"));
        context.Menu.AddItem(new ApplicationMenuItem(OnMonitorMenus.Prefix, displayName: "OnMonitor", "/OnMonitor/4", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
