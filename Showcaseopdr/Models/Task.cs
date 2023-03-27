using System.ComponentModel.DataAnnotations;

namespace Showcaseopdr.Models;

public class Task
{
    [Key]
    public int TaskNumberId { get; set; }
    public string TaskName { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Boolean Present { get; set; }
}