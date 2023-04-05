using System;
using Barclays.TaskList;
using Volo.Abp.Application.Dtos;

namespace Barclays.Tasks;

[Serializable]
public class CreateUpdateTaskDto : AuditedEntityDto<int>
{
    public string Name { get; set; }
    public int Priority { get; set; }
    public TaskStatus Status { get; set; }
}