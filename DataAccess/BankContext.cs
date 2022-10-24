using BankDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDB.DataAccess;

public class BankContext: DbContext
{
    public DbSet<Bank> Bank { get; set; }
    public DbSet<Client> Client { get; set; }
    public DbSet<Bank> Employee { get; set; }
    
    public BankContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BankDB;Username=postgres;Password=1234");
    }
}