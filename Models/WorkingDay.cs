using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class WorkingDay
{
    public string DayOfTheWeek { get; set; }
    public int WorkingDayId { get; set; }
    [Required]
    [MaxLength(15)]
    public string OpenTime { get; set; }
    [Required]
    [MaxLength(15)]
    public string CloseTime { get; set; }
}

