namespace BankDB.Models;

public class Schedule
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Employee> Employee { get; set; }
    public virtual ICollection<WorkingDay> WorkingDays { get; set; }
} 