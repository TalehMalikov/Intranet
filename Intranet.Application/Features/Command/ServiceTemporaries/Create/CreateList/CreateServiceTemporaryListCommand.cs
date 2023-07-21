using Intranet.Domain.Dtos.ServiceTemporaries;
using MediatR;

namespace Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateList
{
    public class CreateServiceTemporaryListCommand : IRequest<List<GetServiceTemporaryDto>>
    {
        public List<CreateServiceTemporaryDto> _createServiceTemporaryDto { get; set; }
        public CreateServiceTemporaryListCommand(List<CreateServiceTemporaryDto> createServiceTemporaryDto)
        {
            _createServiceTemporaryDto = createServiceTemporaryDto;
        }
    }
}
