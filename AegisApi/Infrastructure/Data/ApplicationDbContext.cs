using AegisApi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AegisApi.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<AegisUser>(options)
{
    public DbSet<VaultItem> VaultItems { get; set; }
    public DbSet<VaultItemTag> VaultItemTags { get; set; }
    public DbSet<Folder> Folders { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<EncryptionKey> EncryptionKeys { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        _ = new EntityMapper(builder);
    }
}