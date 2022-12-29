using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankDB.Models;

public class Client : Person
{
    [MaxLength(50)] public string Citizenship { get; set; }

    // relations 
    public virtual ICollection<ServiceForClientInBank> ServiceForClientInBanks { get; set; }
    public virtual ICollection<AccountInBank> AccountsInBank { get; set; }
}