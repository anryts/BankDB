using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class Employee
{
    [Key]   
    public string EmployeeID { get; set; }
    [Required]
    [StringLength(50)] // diff between this and max length?
    public string EmployeeNameFirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string EmployeeNameLastName { get; set; }
    [Required]
    public string EmployeePhone { get; set; }
    public string EmployeeEmail { get; set; }
}