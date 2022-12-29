using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class ServiceInBank
{
    [Key] [Required] public int ServiceInBankId { get; set; }
    public string NameOfService { get; set; }

    // relations
    public virtual Employee Employee { get; set; }
    public virtual ICollection<ServiceForClientInBank> ServiceForClientInBanks { get; set; }
}