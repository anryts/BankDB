using BankDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankDB.Configurations;

public class WorkingDaysConfiguration : IEntityTypeConfiguration<WorkingDay>
{
    public void Configure(EntityTypeBuilder<WorkingDay> builder)
    {
        builder.HasKey(compositeKey => new { compositeKey.WorkingDayId, DayOfTheWeek = compositeKey.DayOfTheWeek })
            .HasName("working_day_id");
        
        
    }
}