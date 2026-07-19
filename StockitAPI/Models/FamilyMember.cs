namespace StockitAPI.Models
{
    public class FamilyMember
    {
        public Guid FamilyId { get; private set; }
        public Family Family { get; private set; } = default!;
        public Guid UserId { get; private set; }
        public User User { get; set; } = default!;
        public DateTime JoinedAt {  get; private set; } = DateTime.UtcNow;
    }
}
