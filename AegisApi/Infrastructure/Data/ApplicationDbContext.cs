using AegisApi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AegisApi.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<AegisUser>
{
    public DbSet<VaultItem> VaultItems { get; set; }
    public DbSet<VaultItemTag> VaultItemTags { get; set; }
    public DbSet<Folder> Folders { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<EncryptionKey> EncryptionKeys { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        _ = new EntityMapper(builder);
    }
}