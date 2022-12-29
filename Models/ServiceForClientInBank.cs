using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BankDB.Models;

public class ServiceForClientInBank
{
    public int ClientId { get; set; }
    public int ServiceInBankId { get; set; }

    public virtual Client Client { get; set; }
    public virtual ServiceInBank ServiceInBank { get; set; }
}