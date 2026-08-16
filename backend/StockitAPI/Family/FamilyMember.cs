namespace StockitAPI.Family
{

    public enum MemberRole{ Owner, Member }

    public class FamilyMember
    {
        public Guid FamilyId { get; private set; }
        public Family Family { get; private set; } = default!;
        public Guid UserId { get; private set; }
        public MemberRole Role { get; private set; }
        public DateTime JoinedAt {  get; private set; } = DateTime.UtcNow;

        internal FamilyMember(Guid familyId, Guid userId, MemberRole role)
        {
            FamilyId = familyId;
            UserId = userId;
            Role = role;
        }

    }
}
