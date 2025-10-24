using System;

namespace AegisApi.Domain.Entities;

public class Folder
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public AegisUser User { get; set; } = default!;
    public ICollection<VaultItem> VaultItems { get; set; } = new List<VaultItem>();
}