using System;

namespace AegisApi.Domain.Entities;

public class EncryptionKey
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string EncryptedKey { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public AegisUser User { get; set; } = default!;
}