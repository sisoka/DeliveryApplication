using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Panda.Domain;
using System;

namespace Panda.Data
{
    public class PandaDbContext : IdentityDbContext<PandaUser, PandaUserRole, string>
    {
        public DbSet<Package> Packages { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        public PandaDbContext(DbContextOptions<PandaDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PandaUser>(entity =>
            {
                entity.HasKey(pu => pu.Id);

                entity.HasMany(pu => pu.Packages)
                      .WithOne(p => p.Recipient)
                      .HasForeignKey(p => p.RecipientId);

                entity.HasMany(pu => pu.Receipts)
                      .WithOne(r => r.Recipient)
                      .HasForeignKey(r => r.RecipientId);
            });

            builder.Entity<Receipt>(entity =>
            {
                entity.HasKey(r => r.ReceiptId);

                entity.HasOne(r => r.Package)
                      .WithOne()
                      .HasForeignKey<Receipt>((r => r.PackageId))
                      .OnDelete(DeleteBehavior.Restrict);
            });
            base.OnModelCreating(builder);
        }
    }
}
