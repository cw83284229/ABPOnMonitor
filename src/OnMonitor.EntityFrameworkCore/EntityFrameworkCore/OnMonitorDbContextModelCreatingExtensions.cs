using Microsoft.EntityFrameworkCore;
using OnMonitor.Monitor;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OnMonitor.EntityFrameworkCore;

public static class OnMonitorDbContextModelCreatingExtensions
{
    public static void ConfigureOnMonitor(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(OnMonitorDbProperties.DbTablePrefix + "Questions", OnMonitorDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */


        builder.Entity<Camera>(b =>
        {
            b.ToTable(OnMonitorDbProperties.DbTablePrefix + "Cameras", OnMonitorDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
           // b.Property(x => x.Camera_ID).IsRequired().HasMaxLength(128);
            //...
        });
      
      
        builder.Entity<Alarm>(b =>
        {
            b.ToTable(OnMonitorDbProperties.DbTablePrefix + "Alarms", OnMonitorDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
           // b.Property(x => x.Id).IsRequired().HasMaxLength(128);
        });
        builder.Entity<MonitorRoom>(b =>
        {
            b.ToTable(OnMonitorDbProperties.DbTablePrefix + "MonitorRooms", OnMonitorDbProperties.DbSchema);
            b.ConfigureByConvention();
            /* Configure more properties here */
        });
    }
}
