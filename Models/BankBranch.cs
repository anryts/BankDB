namespace BankDB.Models;

public class BankBranch
{
    public int BankBranchId { get; set; }
    public string  BankBranchName { get; set; }
    public int BankId { get; set; }
    
    //Navigation Property
    public virtual Bank Bank { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }
}