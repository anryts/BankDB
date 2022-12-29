using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class ServiceInBank
{
    [Key] [Required] public int ServiceInBankId { get; set; }
    public string NameOfService { get; set; }
    public Employee Employee { get; set; }

    // relations
    public ICollection<ServiceForClientInBank> ServiceForClientInBanks { get; set; }
}