namespace StockitAPI.Family
{
    public class Family
    {
        public Guid FamilyId { get; private set; }
        public string? Name { get; private set; }
        private readonly List<FamilyMember> _members = [];
        public IReadOnlyCollection<FamilyMember> Members => _members;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsActive { get; private set; } = true;

        public Family(string name, Guid userId)
        {
            FamilyId = Guid.NewGuid();
            Rename(name);
            IsActive = true;
            AddMember(userId, MemberRole.Owner);
        }

        public void Rename(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddMember(Guid userId, MemberRole role)
        {
            // Verificando se o usuário já é membro da família
            if (_members.Any(m => m.UserId == userId))
            {
                throw new InvalidOperationException("User is already a member of the family.");
            }
            _members.Add(new FamilyMember(FamilyId, userId, role));
            UpdatedAt = DateTime.UtcNow;
        }

        public void Deactivate()
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("Family is already deactivated.");
            }

            IsActive = false;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Activate()
        {
            if (IsActive)
            {
                throw new InvalidOperationException("Family is already activated.");
            }

            IsActive = true;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
