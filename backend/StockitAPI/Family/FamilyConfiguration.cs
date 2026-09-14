using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockitAPI.Family;

public class FamilyConfiguration : IEntityTypeConfiguration<Family>
{
    public void Configure(EntityTypeBuilder<Family> builder)
    {
        builder.Navigation(b => b.Members).HasField("_members");
        builder.HasMany(f => f.Members).WithOne(fm => fm.Family).HasForeignKey(fm => fm.FamilyId);
    }
}