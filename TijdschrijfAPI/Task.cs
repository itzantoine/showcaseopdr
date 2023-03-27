namespace TijdschrijfAPI;

public class Task
{
    public int TaskNumberId { get; set; }
    public string TaskName { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Boolean Present { get; set; }
}