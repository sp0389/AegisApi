using System;
using Microsoft.AspNetCore.Identity;

namespace AegisApi.Domain.Entities;

public class AegisUser : IdentityUser
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Folder> Folders { get; set; } = new List<Folder>();
    public ICollection<VaultItem> VaultItems { get; set; } = new List<VaultItem>();
    public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    public ICollection<EncryptionKey> EncryptionKeys { get; set; } = new List<EncryptionKey>();
}