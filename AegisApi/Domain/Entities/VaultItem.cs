using System;

namespace AegisApi.Domain.Entities;

public class VaultItem
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid FolderId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string EncryptedPassword { get; set; } = string.Empty;
    public string EncryptedNotes { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public Folder Folder { get; set; } = default!;
    public AegisUser User { get; set; } = default!;
    public byte[] Version { get; set; } = [];
    public ICollection<VaultItemTag> Tags { get; set; } = new List<VaultItemTag>();
}