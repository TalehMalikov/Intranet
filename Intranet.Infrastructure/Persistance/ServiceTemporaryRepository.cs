using Dapper;
using Intranet.Domain.Entities.Statistics;
using Intranet.Domain.Repository;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Intranet.Infrastructure.Persistance
{
    public class ServiceTemporaryRepository : IRepository<ServiceTemporary>
    {
        private IDbConnection _db;
        public ServiceTemporaryRepository(IDbConnection db)
        {
            _db = db;
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceTemporary> GetAsync(int id)
        {
            return await _db.QueryFirstAsync<ServiceTemporary>($"select * from statistics.services_temporary where id={id}");
        }

        public async Task<List<ServiceTemporary>> GetListAsync()
        {
            return (await _db.QueryAsync<ServiceTemporary>("select * from statistics.services_temporary"))
                .AsList();
        }

        public async Task<ServiceTemporary> InsertAsync(ServiceTemporary serviceTemporary)
        {
            var query = $"INSERT INTO statistics.services_temporary (hospital_id,stationary_service,ambulatory_service,total_service,comprasion,session_id,is_published,insert_user,update_user) " +
                $"VALUES ({serviceTemporary.HospitalId}, {serviceTemporary.StationaryService},{serviceTemporary.AmbulatoryService}, {serviceTemporary.TotalService},{serviceTemporary.Comprasion},'{serviceTemporary.SessionId}',{serviceTemporary.IsPublished},'{serviceTemporary.InsertUser}','{serviceTemporary.UpdateUser}')";
            
            await _db.ExecuteAsync(query);
            return serviceTemporary;
        }

        public Task<ServiceTemporary> UpdateAsync(int id, ServiceTemporary todoItem)
        {
            throw new NotImplementedException();
        }
    }
}
