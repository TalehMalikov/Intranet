namespace Intranet.Domain.Entities.Statistics
{
    public class ServiceTemporary
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public int StationaryService { get; set; }
        public int AmbulatoryService { get; set; }
        public int TotalService { get; set; }
        public int Comprasion { get; set; }
        public string SessionId { get; set; }
        public int IsPublished { get; set; }
        public string InsertUser { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int IsDeleted { get; set; }
    }
}
