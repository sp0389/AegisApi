using System;

namespace AegisApi.Domain.Entities;

public class VaultItem
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public Guid FolderId { get; set; }
    public byte[] Ciphertext { get; set; } = [];
    public byte[] Nonce { get; set; } = [];
    public byte[] AuthTag { get; set; } = []; // ensure cipher text is not tampered with
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public byte[] Version { get; set; } = [];
    public Folder? Folder { get; set; }
    public AegisUser User { get; set; } = default!;
    public ICollection<VaultItemTag> Tags { get; set; } = new List<VaultItemTag>();
}