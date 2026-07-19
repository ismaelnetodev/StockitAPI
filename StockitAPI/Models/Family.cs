namespace StockitAPI.Models
{
    public class Family
    {
        public Guid FamilyId { get; set; }
        public string? Name { get; set; }
        private readonly List<FamilyMember> _members = [];
        private IReadOnlyCollection<FamilyMember> Members => _members;
    }
}
