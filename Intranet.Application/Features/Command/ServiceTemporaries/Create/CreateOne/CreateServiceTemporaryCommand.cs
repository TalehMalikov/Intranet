using Intranet.Domain.Dtos.ServiceTemporaries;
using MediatR;

namespace Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateOne
{
    public class CreateServiceTemporaryCommand : IRequest<GetServiceTemporaryDto>
    {
        public CreateServiceTemporaryDto _createServiceTemporaryDto { get; set; }
        public CreateServiceTemporaryCommand(CreateServiceTemporaryDto createServiceTemporaryDto)
        {
            _createServiceTemporaryDto = createServiceTemporaryDto;
        }
    }
}
