namespace BankDB.Models;

public class BankBranch
{
    public int BankBranchId { get; set; }
    public string  BankBranchName { get; set; }
    public int BankId { get; set; }
    
    //Navigation Property
    public Bank Bank { get; set; }
    public ICollection<Employee> Employees { get; set; }
}