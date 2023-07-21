using AutoMapper;
using Intranet.Domain.Dtos.ServiceTemporaries;
using Intranet.Domain.Entities.Statistics;
using Intranet.Domain.Repository;
using MediatR;
using System.Threading.Tasks;

namespace Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateOne
{
    public class CreateServiceTemporaryCommandHandler : IRequestHandler<CreateServiceTemporaryCommand, GetServiceTemporaryDto>
    {
        readonly IRepository<ServiceTemporary> _serviceTemporaryRepository;
        IMapper _mapper;
        public CreateServiceTemporaryCommandHandler(IRepository<ServiceTemporary> serviceTemporaryRepository, IMapper mapper)
        {
            _serviceTemporaryRepository = serviceTemporaryRepository;
            _mapper = mapper;
        }
        public async Task<GetServiceTemporaryDto> Handle(CreateServiceTemporaryCommand request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<ServiceTemporary>(request._createServiceTemporaryDto);
            await _serviceTemporaryRepository.InsertAsync(data);

            var mappedData = _mapper.Map<GetServiceTemporaryDto>(data);

            return mappedData;
        }
    }
}
