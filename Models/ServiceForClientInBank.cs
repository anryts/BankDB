using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BankDB.Models;

public class ServiceForClientInBank
{
    public int ClientId { get; set; }
    public int ServiceInBankId { get; set; }

    public Client Client { get; set; }
    public ServiceInBank ServiceInBank { get; set; }
}