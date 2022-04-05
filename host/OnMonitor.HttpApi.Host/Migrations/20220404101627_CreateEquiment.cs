using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnMonitor.Migrations
{
    public partial class CreateEquiment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnMonitorAlarms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 128, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monitoring_room = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AlarmHost_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Alarm_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Build = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    floor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GeteType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SensorType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cost_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    install_time = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Camera_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsAlertor = table.Column<bool>(type: "bit", nullable: true),
                    IsOpenOrClosed = table.Column<bool>(type: "bit", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnMonitorAlarms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnMonitorCameras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monitoring_room = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    channel_ID = table.Column<int>(type: "int", nullable: false),
                    Camera_ID = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Build = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    floor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MonitorClassification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Camera_Tpye = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cost_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    install_time = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Alarm_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnMonitorCameras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnMonitorDVRCheckInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 128, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DVR_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_SN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_Channel = table.Column<int>(type: "int", nullable: true),
                    DiskTotal = table.Column<int>(type: "int", nullable: true),
                    DVRDISK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DVRChannelInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DVRTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DVR_Online = table.Column<bool>(type: "bit", nullable: true),
                    TimeInfoChenk = table.Column<bool>(type: "bit", nullable: true),
                    DiskChenk = table.Column<bool>(type: "bit", nullable: true),
                    SNChenk = table.Column<bool>(type: "bit", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnMonitorDVRCheckInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnMonitorDVRs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Factory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Monitoring_room = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Camera_build = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Camera_foor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_ID = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Home_server = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Hard_drive = table.Column<int>(type: "int", nullable: true),
                    DVR_IP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_port = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_usre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_possword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    install_time = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_SN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DVR_Channel = table.Column<int>(type: "int", nullable: true),
                    department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cost_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnMonitorDVRs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnMonitorMonitorRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Factory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RoomLocation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnMonitorMonitorRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnMonitorProjectManages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 128, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectManageType = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    ProjectOrder = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    StartWorkDate = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    CompleteDate = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    AcceptanceData = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    ManufacturerName = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    ProjectSpecifications = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Build = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Floor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Camera_ID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AcceptanceResult = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnMonitorProjectManages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnMonitorAlarms");

            migrationBuilder.DropTable(
                name: "OnMonitorCameras");

            migrationBuilder.DropTable(
                name: "OnMonitorDVRCheckInfos");

            migrationBuilder.DropTable(
                name: "OnMonitorDVRs");

            migrationBuilder.DropTable(
                name: "OnMonitorMonitorRooms");

            migrationBuilder.DropTable(
                name: "OnMonitorProjectManages");
        }
    }
}
