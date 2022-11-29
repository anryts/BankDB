using BankDB.Configurations;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BankDB.DataAccess;

public class BankContext : DbContext
{
    public DbSet<Bank> Bank { get; set; }
    public DbSet<Client> Client { get; set; }

    public BankContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSnakeCaseNamingConvention();

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsetings.json")
            .Build();
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var serviceForClientInBank = modelBuilder.Entity<ServiceForClientInBank>();
        serviceForClientInBank.HasKey(s => new { s.ClientId, s.ServiceInBankId });

        modelBuilder.Entity<Bank>()
            .HasMany(b => b.BankBranches)
            .WithOne(b => b.Bank);

        modelBuilder.Entity<AccountInBank>()
            .HasMany(b => b.Transactions)
            .WithOne(x => x.AccountInBank);
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new WorkingDaysConfiguration());
    }
}