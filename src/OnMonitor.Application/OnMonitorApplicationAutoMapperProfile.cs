using AutoMapper;
using OnMonitor.Monitor;

namespace OnMonitor;

public class OnMonitorApplicationAutoMapperProfile : Profile
{
    public OnMonitorApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Camera, CameraDto>();
        CreateMap<UpdateCameraDto, Camera>(MemberList.Source);
      
      
        CreateMap<Alarm, AlarmDto>();
        CreateMap<UpdateAlarmDto, Alarm>(MemberList.Source);

        CreateMap<MonitorRoom, MonitorRoomDto>();
        CreateMap<UpdateMonitorRoomDto, MonitorRoom>(MemberList.Source);
    }
}
