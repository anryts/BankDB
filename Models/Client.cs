using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankDB.Models;

public class Client : Person
{
    [MaxLength(50)] public string Citizenship { get; set; }

    // relations
    public List<ServiceForClientInBank> ServiceForClientInBanks { get; set; }
    public List<AccountInBank> AccountsInBank { get; set; }
}