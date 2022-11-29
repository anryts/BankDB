using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankDB.Models;

/// <summary>
/// parent class for Client and Employee
/// </summary>
public class Person
{
    [Key] [Column("person_id")]public int PersonId { get; set; }
    [Required] [MaxLength(20)] public string FirstName { get; set; }
    [Required] [MaxLength(20)] public string LastName { get; set; }
    [Required] [MaxLength(20)] [EmailAddress]public string EmailAddres { get; set; }
}