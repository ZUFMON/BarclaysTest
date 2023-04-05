namespace Barclays.TaskList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

public class Task : AggregateRoot<int>
{
    public string Name { get; set; }
    public int Priority { get; set; }
    public TaskStatus Status { get; set; }
}
