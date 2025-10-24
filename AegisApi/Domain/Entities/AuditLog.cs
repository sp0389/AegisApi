using System;
using AegisApi.Domain.Enum;

namespace AegisApi.Domain.Entities;

public class AuditLog
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public VaultItemActionType VaultItemAction { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public AegisUser User { get; set; } = default!;
}