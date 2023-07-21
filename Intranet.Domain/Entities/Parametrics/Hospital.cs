namespace Intranet.Domain.Entities.Parametrics
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Region_Id { get; set; }
        public DateTime Insert_Date { get; set; }
        public string Insert_User { get; set; }
        public DateTime Update_Date { get; set; }
        public string Update_User { get; set; }
        public int Is_Deleted { get; set; }

    }
}
