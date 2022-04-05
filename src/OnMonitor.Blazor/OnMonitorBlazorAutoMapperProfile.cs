using AutoMapper;
using OnMonitor.Blazor.Pages.Equiment;
using OnMonitor.Monitor;

namespace OnMonitor.Blazor;

public class OnMonitorBlazorAutoMapperProfile : Profile
{
    public OnMonitorBlazorAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //CreateMap<MonitorRoom, MonitorRoomDto>();
        //CreateMap<UpdateMonitorRoomDto, MonitorRoom>(MemberList.Source);
    }
}
