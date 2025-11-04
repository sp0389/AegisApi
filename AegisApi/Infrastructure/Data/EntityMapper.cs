using AegisApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AegisApi.Infrastructure.Data;

public static class EntityMapper
{
    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<AegisUser>(au =>
        {
            au.Property(au => au.UserName).HasMaxLength(50);
            
            au.HasMany(au => au.Folders)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            au.HasMany(au => au.VaultItems)
                .WithOne(vi => vi.User)
                .HasForeignKey(vi => vi.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            au.HasMany(au => au.AuditLogs)
                .WithOne(al => al.User)
                .HasForeignKey(al => al.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            au.HasMany(au => au.EncryptionKeys)
                .WithOne(ek => ek.User)
                .HasForeignKey(ek => ek.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<Folder>(f =>
        {
            f.HasMany(f => f.VaultItems)
                .WithOne(vi => vi.Folder)
                .HasForeignKey(vi => vi.FolderId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<VaultItem>(vi =>
        {
            vi.HasIndex(vi => vi.UserId);
            vi.HasIndex(vi => vi.FolderId);
            
            vi.HasMany(vi => vi.Tags)
                .WithOne(t => t.VaultItem)
                .HasForeignKey(t => t.VaultItemId)
                .OnDelete(DeleteBehavior.Cascade);

            vi.Property(vi => vi.Version)
                .IsRowVersion();
        });
    }
}