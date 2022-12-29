using BankDB.Configurations;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BankDB.DataAccess;

public class BankContext : DbContext
{
    public DbSet<Bank> Banks { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<AccountInBank> AccountInBanks { get; set; }

    public BankContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSnakeCaseNamingConvention();
       

        var configuration = new ConfigurationBuilder()
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
        
        modelBuilder.Entity<Schedule>()
            .HasMany(x=> x.Employee)
            .WithOne(x=> x.EmployeeSchedule);
        
        modelBuilder.Entity<Schedule>()
            .HasMany(x=> x.WorkingDays)
            .WithOne(x=> x.Schedule);
        
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new WorkingDaysConfiguration());
    }
}