using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OnMonitor.Monitor
{

    // [Authorize(Roles ="admin")]
    public class MonitorRoomAppService :// ApplicationService
  CrudAppService<
  MonitorRoom,//定义实体
  MonitorRoomDto,//定义DTO
  int, //实体的主键
  PagedAndSortedResultRequestDto, //获取分页排序
  UpdateMonitorRoomDto> //用于更新实体
  , IMonitorRoomAppService

    {
       
        public MonitorRoomAppService(IRepository<MonitorRoom, int> repository) : base(repository)
        {

           
        }
        public Task<string> GettoString()
        {
            return Task.FromResult("我是一个测试文件");



        }












    }








    //}






}




   



   

