using AutoMapper;
using Intranet.Application.Features.Command.ServiceTemporaries.Create;
using Intranet.Domain.Dtos.ServiceTemporaries;
using Intranet.Domain.Entities.Statistics;

namespace Intranet.Application.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
           CreateMap<CreateServiceTemporaryDto, ServiceTemporary>()
                .ReverseMap();
            CreateMap<ServiceTemporary, GetServiceTemporaryDto>()
                .ReverseMap();
        }
    }
}
