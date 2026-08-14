using Microsoft.AspNetCore.Identity;

namespace StockitAPI.Models;

    public class User
    {
        public Guid UserId { get; private set; }
        public string Name { get; private set; } = default!;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsActive { get; private set; }

        public User(string name)
        {
            UserId = Guid.NewGuid();
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

        public void Deactivate()
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("User is already deactivated.");
            }

            IsActive = false;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Activate()
        {
            if (IsActive)
            {
                throw new InvalidOperationException("User is already activated.");
            }

            IsActive = true;
            UpdatedAt = DateTime.UtcNow;
        }
    }