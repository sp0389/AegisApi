using System;
using AegisApi.Domain.Enum;

namespace AegisApi.Domain.Entities;

public class VaultItemTag
{
    public Guid Id { get; set; }
    public Guid VaultItemId { get; set; }
    public VaultItem VaultItem { get; set; } = default!;
    public VaultItemTagType VaultItemTagType { get; set; }
}