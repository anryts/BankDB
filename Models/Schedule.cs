namespace BankDB.Models;

public class Schedule
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    
    public ICollection<Employee> Employee { get; set; }
    public ICollection<WorkingDay> WorkingDays { get; set; }
}