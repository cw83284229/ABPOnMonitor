using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace OnMonitor.EntityFrameworkCore;

[ConnectionStringName(OnMonitorDbProperties.ConnectionStringName)]
public class OnMonitorDbContext : AbpDbContext<OnMonitorDbContext>, IOnMonitorDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

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
