namespace Intranet.Domain.Entities.Statistics
{
    public class ServiceFile
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string FileName { get; set; }
        public int IsActive { get; set; }
        public int IsPublished { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
