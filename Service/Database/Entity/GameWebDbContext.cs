using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Services.Database.Model;

namespace Services.Database.Entity
{
  public class GameWebDbContext : DbContext
  {
    public GameWebDbContext(DbContextOptions<GameWebDbContext> options) : base(options)
    {
    }
    public DbSet<UserBasic> UserBasic { get; set; }

    private void RenewMacroColumn()
    {
      DateTime systemDateTime = DateTime.Now;
      foreach (var dbEntry in ChangeTracker.Entries())
      {
        switch (dbEntry.State)
        {
          case EntityState.Added:

            CreateWithValues(dbEntry, "Gid", System.Guid.NewGuid());
            CreateWithValues(dbEntry, "CreatedAt", systemDateTime);
            CreateWithValues(dbEntry, "UpdatedAt", systemDateTime);
            break;

          case EntityState.Modified:
            CreateWithValues(dbEntry, "UpdatedAt", systemDateTime);
            break;
        }
      }
    }

    private static void CreateWithValues(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry dbEntry, string propertyName, object value)
    {
      try
      {
        if (dbEntry.Property(propertyName) != null)
        {
          dbEntry.Property(propertyName).CurrentValue = value;
        }
      }
      catch { }
    }

    public override int SaveChanges()
    {
      RenewMacroColumn();
      return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
      RenewMacroColumn();
      return (await base.SaveChangesAsync(true, cancellationToken));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //modelBuilder.Entity<Member>().HasData(
      //  new Member
      //  {
      //    Gid = Guid.NewGuid(),
      //    Account = "admin_advmeds",
      //    Password = "advmeds2019",
      //    Birthday = DateTime.Now.Date,
      //    Enable = Status.Enable,
      //    Role = Role.SysAdmin,
      //    Sex = Sex.Unknown,
      //    Email = "server@advmeds.com",
      //    CreatedAt = DateTime.Now,
      //    UpdatedAt = DateTime.Now
      //  });
      //modelBuilder.Entity<Member>().HasData(
      //  new Member
      //  {
      //    Gid = Guid.NewGuid(),
      //    Account = "admin_hero",
      //    Password = "hero2019",
      //    Birthday = DateTime.Now.Date,
      //    Enable = Status.Enable,
      //    Role = Role.BackAdmin,
      //    Sex = Sex.Unknown,
      //    Email = "server@advmeds.com",
      //    CreatedAt = DateTime.Now,
      //    UpdatedAt = DateTime.Now
      //  });
    }

  }
}
