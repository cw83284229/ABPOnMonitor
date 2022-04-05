using Microsoft.EntityFrameworkCore;
using OnMonitor.Monitor;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OnMonitor.EntityFrameworkCore;

[ConnectionStringName(OnMonitorDbProperties.ConnectionStringName)]
public interface IOnMonitorDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    //设定监控镜头实体类
    public DbSet<Camera> Cameras { get; set; }
    public DbSet<Alarm> Alarms { get; set; }
    public DbSet<MonitorRoom> MonitorRooms { get; set; }
}
