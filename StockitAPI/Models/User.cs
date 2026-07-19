using Microsoft.AspNetCore.Identity;

namespace StockitAPI.Models
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; private set; } = default!;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsActive { get; private set; }

        private readonly List<FamilyMember> _families = [];
        public IReadOnlyCollection<FamilyMember> Families => _families;
    }
}
