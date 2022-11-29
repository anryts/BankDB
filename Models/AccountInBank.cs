using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class AccountInBank
{
    [Key]
    public int AccountId { get; set; }
    public decimal AmountOnAccount { get; set; }
    public string Currency { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
    
    
}