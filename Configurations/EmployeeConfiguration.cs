using BankDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankDB.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasOne(x => x.BankBranch)
            .WithMany(x => x.Employees);
        
        builder.Property(employee => employee.EmployeePhone).IsRequired().HasMaxLength(50);
        builder.Property(employee => employee.OccupationId).IsRequired();
        builder.Property(employee => employee.BankBranchId).IsRequired();
        
    }
}