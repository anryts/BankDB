using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class Client
{
    [Key]
    public int ClientId { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    
    [MaxLength(50)]
    public string EmailAddress { get; set; }
    [Required]
    public List<AccountInBank> AccountsInBank { get; set; }
}