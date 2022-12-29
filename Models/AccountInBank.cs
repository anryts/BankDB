using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class AccountInBank
{
    [Key] public int AccountId { get; set; }
    public decimal AmountOnAccount { get; set; }
    public string Currency { get; set; }

    public virtual Client Client { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; }
}