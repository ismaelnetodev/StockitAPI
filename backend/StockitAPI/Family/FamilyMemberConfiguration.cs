using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockitAPI.Family;

public class FamilyMemberConfiguration : IEntityTypeConfiguration<FamilyMember>
{
    public void Configure(EntityTypeBuilder<FamilyMember> builder)
    {
        builder.HasKey(k => new { k.FamilyId, k.UserId });
        builder.ToTable("FamilyMembers");
        builder.HasIndex(fm => fm.UserId);

    }
}