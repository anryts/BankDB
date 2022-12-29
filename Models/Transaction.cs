using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class Transaction
{
    [Key] public string TransactionId { get; set; }
    [Required] public int AccountId { get; set; }
    [Required] public int EmployeeId { get; set; }
    [Required] public string TransactionName { get; set; }
    public int  AccountInBankId { get; set; }

    public virtual AccountInBank AccountInBank { get; set; }
}