using AutoMapper;
using Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateOne;
using Intranet.Domain.Dtos.ServiceTemporaries;
using Intranet.Domain.Entities.Statistics;
using Intranet.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Application.Features.Command.ServiceTemporaries.Create.CreateList
{
    public class CreateServiceTemporaryCommandListHandler : IRequestHandler<CreateServiceTemporaryListCommand, List<GetServiceTemporaryDto>>
    {
        readonly IRepository<ServiceTemporary> _serviceTemporaryRepository;
        IMapper _mapper;
        public CreateServiceTemporaryCommandListHandler(IRepository<ServiceTemporary> serviceTemporaryRepository, IMapper mapper)
        {
            _serviceTemporaryRepository = serviceTemporaryRepository;
            _mapper = mapper;
        }
       

        public async Task<List<GetServiceTemporaryDto>> Handle(CreateServiceTemporaryListCommand request, CancellationToken cancellationToken)
        {
            var Newlist=new List<GetServiceTemporaryDto>();
            foreach (var item in request._createServiceTemporaryDto)
            {
                var data = _mapper.Map<ServiceTemporary>(item);
                await _serviceTemporaryRepository.InsertAsync(data);

                var mappedData = _mapper.Map<GetServiceTemporaryDto>(data);
                Newlist.Add(mappedData);
            }
            return Newlist;
        }
    }
}
