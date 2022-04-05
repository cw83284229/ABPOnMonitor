using Microsoft.EntityFrameworkCore;
using OnMonitor.Monitor;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OnMonitor.EntityFrameworkCore;

[ConnectionStringName(OnMonitorDbProperties.ConnectionStringName)]
public class OnMonitorDbContext : AbpDbContext<OnMonitorDbContext>, IOnMonitorDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */


    //设定监控镜头实体类
    public DbSet<Camera> Cameras { get; set; }

    public DbSet<Alarm> Alarms { get; set; }
    public DbSet<MonitorRoom> MonitorRooms { get; set; }

    public OnMonitorDbContext(DbContextOptions<OnMonitorDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOnMonitor();
    }
}
