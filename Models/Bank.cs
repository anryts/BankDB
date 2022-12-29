using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class Bank
{
    [Key] public int BankId { get; set; }
    [Required] [MaxLength(50)] public string BankName { get; set; }
    [Required] [MaxLength(50)] public string BankAddress { get; set; }
    public virtual ICollection<BankBranch>? BankBranches { get; set; }
}