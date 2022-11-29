using System.ComponentModel.DataAnnotations.Schema;

namespace BankDB.Models;

public class Employee : Person
{
    public string EmployeePhone { get; set; }
    public int OccupationId { get; set; }
    public int BankBranchId { get; set; }

    public Occupation Occupation { get; set; } = null!;
    public BankBranch BankBranch { get; set; } = null!;
}