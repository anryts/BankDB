using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class ServiceInBank
{
    [Key] [Required] public int ServiceInBankId { get; set; }
    public string NameOfService { get; set; }
    public Client Client { get; set; }
    public Employee Employee { get; set; }
    public DateTime DateOfService { get; set; }

    // relations
    public List<ServiceForClientInBank> ServiceForClientInBanks { get; set; }
}