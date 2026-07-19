namespace StockitAPI.Models
{
    public class FamilyMember
    {
        public Guid UserId { get; set; }
        public User MyProperty { get; set; }
    }
}
