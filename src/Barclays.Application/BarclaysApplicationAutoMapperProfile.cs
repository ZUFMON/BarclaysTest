using AutoMapper;
using Barclays.TaskList;
using Barclays.Tasks;

namespace Barclays;

public class BarclaysApplicationAutoMapperProfile : Profile
{
    public BarclaysApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Task, TaskDto>();

     
        CreateMap< TaskDto,Task>();
    }
}
