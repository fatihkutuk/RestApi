using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.DbContexts
{
    public class MyDBContext : DbContext
    {
        public DbSet<Companies> Companies { get; set; }
        public DbSet<CompanyGroups> CompanyGroups { get; set; }
       

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Companies

            modelBuilder.Entity<Companies>().ToTable("Companies");
            modelBuilder.Entity<Companies>().HasKey(c => c.Id).HasName("PK_Companies");
            modelBuilder.Entity<Companies>().Property(c => c.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyGroupId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyAdressCityId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyAdressCountyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyAdressNeighborhoodId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyAdressStreetId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyAddress).HasColumnType("nvarchar(300)").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyLocation).HasColumnType("text").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyDelegateName).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyDelegatePhoneNumber).HasColumnType("nvarchar(20)").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CompanyMail).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Companies>().Property(c => c.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);

            // CompanyGroups

            modelBuilder.Entity<CompanyGroups>().ToTable("CompanyGroups");
            modelBuilder.Entity<CompanyGroups>().HasKey(c => c.Id).HasName("PK_CompanyGroups");
            modelBuilder.Entity<CompanyGroups>().Property(c => c.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyGroups>().Property(c => c.CompanyGroupName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<CompanyGroups>().Property(c => c.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyGroups>().Property(c => c.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);





            //modelBuilder.Entity<User>().HasOne<UserGroup>().WithMany().HasPrincipalKey(ug => ug.Id).HasForeignKey(u => u.UserGroupId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Users_UserGroups");
        }
    }
}
