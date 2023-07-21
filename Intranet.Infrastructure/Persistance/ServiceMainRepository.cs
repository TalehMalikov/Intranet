using Intranet.Domain.Entities.Statistics;
using Intranet.Domain.Repository;

namespace Intranet.Infrastructure.Persistance
{
    public class ServiceMainRepository : IRepository<ServiceMain>
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceMain> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceMain>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceMain> InsertAsync(ServiceMain todoItem)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceMain> UpdateAsync(int id, ServiceMain todoItem)
        {
            throw new NotImplementedException();
        }
    }
}
