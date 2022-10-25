using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class AccountInBank
{
    [Key]
    public int AccountID { get; set; }
    public decimal AmountOnAccount { get; set; }
    public string Currency { get; set; }
}