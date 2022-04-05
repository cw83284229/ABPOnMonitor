using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OnMonitor.Monitor
{

    // [Authorize(Roles ="admin")]
    public interface IMonitorRoomAppService: 
  ICrudAppService<
  MonitorRoomDto,//定义DTO
  int, //实体的主键
  PagedAndSortedResultRequestDto, //获取分页排序
  UpdateMonitorRoomDto> //用于更新实体
  

    {


        public Task<string> GettoString();











    }








    //}






}




   



   

