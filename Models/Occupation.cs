using System.ComponentModel.DataAnnotations;

namespace BankDB.Models;

public class Occupation
{
    [Key] public int OccupationId { get; set; }

    [Required][MaxLength(50)] public string OccupationName { get; set; }

}