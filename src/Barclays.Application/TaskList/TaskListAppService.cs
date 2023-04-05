using System.Threading.Tasks;
using Barclays.IServices;
using Barclays.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Validation;

namespace Barclays.TaskList;

public class TaskListAppService : CrudAppService<
        Task, //The Task entity
        TaskDto, //Used to show tasks
        int, //Primary key of the task entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateTaskDto>, ////Used to create/update a book
    ITaskListAppService
{
    private readonly IRepository<Task, int> _repository;

    public TaskListAppService(IRepository<Task, int> repository) : base(repository)
    {
        _repository = repository;
    }

    public override async System.Threading.Tasks.Task DeleteAsync(int id)
    {
        var task = await _repository.GetAsync(id);
        if (task != null)
        {
            if (task.Status == TaskStatus.Completed)
            {
                await base.DeleteByIdAsync(id);
            }
            else
            {
                throw new AbpValidationException(
                    $"The task name '{task.Name}' is not in status '{nameof(TaskStatus.Completed)}'." +
                    $"Please change the status to '{nameof(TaskStatus.Completed)}' save data and then delete the task.");
            }
        }

        throw new EntityNotFoundException($"The Task with id '{id}' not found in database.");
    }
    
}