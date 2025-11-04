using System;

namespace AegisApi.Domain.Entities;

public class EncryptionKey
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public byte[] EncryptedDataKey { get; set; } = [];
    public byte[] Nonce { get; set; } = [];
    public byte[] AuthTag { get; set; } = [];
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public AegisUser User { get; set; } = default!;
}