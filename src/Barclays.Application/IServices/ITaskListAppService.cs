using Volo.Abp.Application.Services;
using Barclays.TaskList;
using Barclays.Tasks;
using Volo.Abp.Application.Dtos;

namespace Barclays.IServices;


public interface ITaskListAppService : ICrudAppService<TaskDto, int, PagedAndSortedResultRequestDto, CreateUpdateTaskDto>
{
}