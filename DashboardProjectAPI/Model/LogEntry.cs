namespace DashboardProjectAPI.Model
{   
    public class LogEntryModel
    {
        public int Id {get; set;}
        public DateTime TimeStamp {get; set;}
        public required string Severity {get; set;}
        public required string Message {get; set;}
    }
}