using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using RestApi.Models.Address;
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
        public DbSet<Cties> Cties { get; set; }
       

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Companies

            modelBuilder.Entity<Companies>().ToTable("Companies");
            modelBuilder.Entity<Companies>().HasKey(company => company.Id).HasName("PK_Companies");
            modelBuilder.Entity<Companies>().Property(company => company.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyGroupId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyAdressCityId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyAdressCountyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyAdressNeighborhoodId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyAdressStreetId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyAddress).HasColumnType("nvarchar(300)").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyLocation).HasColumnType("text").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyDelegateName).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyDelegatePhoneNumber).HasColumnType("nvarchar(20)").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CompanyMail).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);

            // CompanyGroups

            modelBuilder.Entity<CompanyGroups>().ToTable("CompanyGroups");
            modelBuilder.Entity<CompanyGroups>().HasKey(cgroup => cgroup.Id).HasName("PK_CompanyGroups");
            modelBuilder.Entity<CompanyGroups>().Property(cgroup => cgroup.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyGroups>().Property(cgroup => cgroup.CompanyGroupName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<CompanyGroups>().Property(cgroup => cgroup.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyGroups>().Property(cgroup => cgroup.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);

            // Cties

            modelBuilder.Entity<Cties>().ToTable("Cties");
            modelBuilder.Entity<Cties>().HasKey(city => city.Id).HasName("PK_Cties");
            modelBuilder.Entity<Cties>().Property(city => city.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Cties>().Property(city => city.CityName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Cties>().Property(city => city.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Cties>().Property(city => city.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);

            // Counties

            modelBuilder.Entity<Counties>().ToTable("Counties");
            modelBuilder.Entity<Counties>().HasKey(county => county.Id).HasName("PK_Counties");
            modelBuilder.Entity<Counties>().Property(county => county.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Counties>().Property(county => county.CountyName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Counties>().Property(county => county.CityId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Counties>().Property(county => county.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Counties>().Property(county => county.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<Counties>().HasOne<Cties>().WithMany().HasPrincipalKey(city => city.Id).HasForeignKey(county => county.CityId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Counties_Cties");

            // Neighborhoods

            modelBuilder.Entity<Neighborhood>().ToTable("Neighborhoods");
            modelBuilder.Entity<Neighborhood>().HasKey(neigh => neigh.Id).HasName("PK_Neighborhoods");
            modelBuilder.Entity<Neighborhood>().Property(neigh => neigh.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Neighborhood>().Property(neigh => neigh.NeighborhoodName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Neighborhood>().Property(neigh => neigh.CountyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Neighborhood>().Property(neigh => neigh.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Neighborhood>().Property(neigh => neigh.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<Neighborhood>().HasOne<Counties>().WithMany().HasPrincipalKey(county => county.Id).HasForeignKey(neigh => neigh.CountyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Neighborhoods_Counties");

            // Streets

            modelBuilder.Entity<Streets>().ToTable("Streets");
            modelBuilder.Entity<Streets>().HasKey(street => street.Id).HasName("PK_Streets");
            modelBuilder.Entity<Streets>().Property(street => street.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Streets>().Property(street => street.StreetName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Streets>().Property(street => street.NeighborhoodId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Streets>().Property(street => street.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Streets>().Property(street => street.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<Streets>().HasOne<Neighborhood>().WithMany().HasPrincipalKey(neigh => neigh.Id).HasForeignKey(street => street.NeighborhoodId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Streets_Neighborhoods");


        }
    }
}
