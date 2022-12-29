using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class WorkingDay
{
    public string DayOfTheWeek { get; set; }
    public int WorkingDayId { get; set; } 
    [Required]
    public string OpenTime { get; set; }
    [Required]
    public string CloseTime { get; set; }


    public Schedule Schedule { get; set; }
   //    public DateTimeOffset OpenTime { get; set; } 
}

