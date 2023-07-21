using Intranet.Domain.Entities.Parametrics;

namespace Intranet.Domain.Dtos.ServiceTemporaries
{
    public class GetServiceTemporaryDto
    {
        public int HospitalId { get; set; }
        public int StationaryService { get; set; }
        public int AmbulatoryService { get; set; }
        public int TotalService { get; set; }
        public int Comprasion { get; set; }
        public string SessionId { get; set; }
        public string InsertUser { get; set; }
        public string UpdateUser { get; set; }
        public List<Hospital> Hospitals { get; set; }
    }
}
