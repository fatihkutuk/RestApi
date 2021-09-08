using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using RestApi.Models.Address;
using RestApi.Models.Company;
using RestApi.Models.User;
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
        public DbSet<Counties> Counties { get; set; }
        public DbSet<Cties> Cties { get; set; }
        public DbSet<Streets> Streets { get; set; }
        public DbSet<CompanyImages> CompanyImages { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<CompanyComments> CompanyComments { get; set; }
        public DbSet<CompanyTables> CompanyTables { get; set; }
        public DbSet<UserAppointmentsSelectedTables> UserAppointmentsSelectedTables { get; set; }
        public DbSet<CompanyAppointmentTimes> CompanyAppointmentTimes { get; set; }
        public DbSet<CompanyWorks> CompanyWorks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserAppointments> UserAppointments { get; set; }
        public DbSet<UserAppointmentsSelectedWorks> UserAppointmentsSelectedWorks { get; set; }
       
       

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
            modelBuilder.Entity<Companies>().Property(company => company.isTable).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Companies>().Property(company => company.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<Companies>().HasOne<CompanyGroups>().WithMany().HasPrincipalKey(cGroup => cGroup.Id).HasForeignKey(company => company.CompanyGroupId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_CompanyGroup_Companies");

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

            // CompanyImges

            modelBuilder.Entity<CompanyImages>().ToTable("CompanyImages");
            modelBuilder.Entity<CompanyImages>().HasKey(cImage => cImage.Id).HasName("PK_CompanyImages");
            modelBuilder.Entity<CompanyImages>().Property(cImage => cImage.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyImages>().Property(cImage => cImage.CompanyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<CompanyImages>().Property(cImage => cImage.ImageDescription).HasColumnType("nvarchar(500)").IsRequired();
            modelBuilder.Entity<CompanyImages>().Property(cImage => cImage.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyImages>().Property(cImage => cImage.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<CompanyImages>().HasOne<Companies>().WithMany().HasPrincipalKey(company => company.Id).HasForeignKey(cImage => cImage.CompanyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Company_CompanyImages");

            // CompanyComments

            modelBuilder.Entity<CompanyComments>().ToTable("CompanyComments");
            modelBuilder.Entity<CompanyComments>().HasKey(cComment => cComment.Id).HasName("PK_CompanyComments");
            modelBuilder.Entity<CompanyComments>().Property(cComment => cComment.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyComments>().Property(cComment => cComment.UserId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<CompanyComments>().Property(cComment => cComment.Comment).HasColumnType("nvarchar(500)").IsRequired();
            modelBuilder.Entity<CompanyComments>().Property(cComment => cComment.isConfirmed).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<CompanyComments>().Property(cComment => cComment.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyComments>().Property(cComment => cComment.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<CompanyComments>().HasOne<Companies>().WithMany().HasPrincipalKey(company => company.Id).HasForeignKey(cImage => cImage.CompanyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Company_CompanyComments");
            modelBuilder.Entity<CompanyComments>().HasOne<Users>().WithMany().HasPrincipalKey(user => user.Id).HasForeignKey(cComment => cComment.UserId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_User_CompanyComments");

            // CompanyAppointmentTimes

            modelBuilder.Entity<CompanyAppointmentTimes>().ToTable("CompanyAppointmentTimes");
            modelBuilder.Entity<CompanyAppointmentTimes>().HasKey(caTimes => caTimes.Id).HasName("PK_CompanyAppointmentTimes");
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.CompanyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.TimeToStart).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.TimeToFinish).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.isAvailable).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyAppointmentTimes>().Property(caTimes => caTimes.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<CompanyAppointmentTimes>().HasOne<Companies>().WithMany().HasPrincipalKey(company => company.Id).HasForeignKey(caTimes => caTimes.CompanyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Company_CompanyAppointmentTimes");

            // CompanyWorks

            modelBuilder.Entity<CompanyWorks>().ToTable("CompanyWorks");
            modelBuilder.Entity<CompanyWorks>().HasKey(cWorks => cWorks.Id).HasName("PK_CompanyWorks");
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.CompanyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.Description).HasColumnType("nvarchar(500)").IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.ImagePath).HasColumnType("nvarchar(200)").IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.DurationMin).HasColumnType("double").IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.Price).HasColumnType("double").IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyWorks>().Property(cWorks => cWorks.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<CompanyWorks>().HasOne<Companies>().WithMany().HasPrincipalKey(company => company.Id).HasForeignKey(cWorks => cWorks.CompanyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Company_CompanyWorks");

            // CompanyTables

            modelBuilder.Entity<CompanyTables>().ToTable("CompanyTables");
            modelBuilder.Entity<CompanyTables>().HasKey(cTable => cTable.Id).HasName("PK_CompanyTables");
            modelBuilder.Entity<CompanyTables>().Property(cTable => cTable.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<CompanyTables>().Property(cTable => cTable.CompanyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<CompanyTables>().Property(cTable => cTable.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<CompanyTables>().Property(cTable => cTable.isAvailable).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<CompanyTables>().Property(cTable => cTable.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<CompanyTables>().Property(cTable => cTable.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<CompanyTables>().HasOne<Companies>().WithMany().HasPrincipalKey(company => company.Id).HasForeignKey(cTable => cTable.CompanyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Company_CompanyTables");

            // UserAppointmentsSelectedWorks

            modelBuilder.Entity<UserAppointmentsSelectedWorks>().ToTable("UserAppointmentsSelectedWorks");
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().HasKey(uasWorks => uasWorks.Id).HasName("PK_UserAppointmentsSelectedWorks");
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.UserId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.UserAppointmentId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.CompanyId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.CompanyWorkId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().Property(uasWorks => uasWorks.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().HasOne<Users>().WithMany().HasPrincipalKey(user => user.Id).HasForeignKey(uasWorks => uasWorks.UserId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_User_PK_UserAppointmentsSelectedWorks");
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().HasOne<UserAppointments>().WithMany().HasPrincipalKey(userAppoint => userAppoint.Id).HasForeignKey(uasWorks => uasWorks.UserAppointmentId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_UserAppointments_PK_UserAppointmentsSelectedWorks");
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().HasOne<Companies>().WithMany().HasPrincipalKey(company => company.Id).HasForeignKey(uasWorks => uasWorks.CompanyId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Company_PK_UserAppointmentsSelectedWorks");
            modelBuilder.Entity<UserAppointmentsSelectedWorks>().HasOne<CompanyWorks>().WithMany().HasPrincipalKey(companywork => companywork.Id).HasForeignKey(uasWorks => uasWorks.CompanyWorkId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_CompanyWork_PK_UserAppointmentsSelectedWorks");

            //UserAppointmentsSelectedTables

            modelBuilder.Entity<UserAppointmentsSelectedTables>().ToTable("UserAppointmentsSelectedTables");
            modelBuilder.Entity<UserAppointmentsSelectedTables>().HasKey(uasTables => uasTables.Id).HasName("PK_UserAppointments");
            modelBuilder.Entity<UserAppointmentsSelectedTables>().Property(uasTables => uasTables.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedTables>().Property(uasTables => uasTables.UserAppointmentId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedTables>().Property(uasTables => uasTables.TableId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedTables>().Property(uasTables => uasTables.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<UserAppointmentsSelectedTables>().Property(uasTables => uasTables.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<UserAppointmentsSelectedTables>().HasOne<UserAppointments>().WithMany().HasPrincipalKey(usera => usera.Id).HasForeignKey(uasTables => uasTables.UserAppointmentId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_UserAppointments_UserAppointmentsSelectedTables");
            modelBuilder.Entity<UserAppointmentsSelectedTables>().HasOne<CompanyTables>().WithMany().HasPrincipalKey(cTables => cTables.Id).HasForeignKey(uasTables => uasTables.TableId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_CompanyTables_UserAppointmentsSelectedTables");

            // UserAppointments

            modelBuilder.Entity<UserAppointments>().ToTable("UserAppointments");
            modelBuilder.Entity<UserAppointments>().HasKey(userAppoint => userAppoint.Id).HasName("PK_UserAppointments");
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.UserId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.CompanyAppointmentTimeId).HasColumnType("int").IsRequired();
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.isConfirmed).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.isFinished).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<UserAppointments>().Property(userAppoint => userAppoint.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);
            modelBuilder.Entity<UserAppointments>().HasOne<Users>().WithMany().HasPrincipalKey(user => user.Id).HasForeignKey(userAppoint => userAppoint.UserId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_User_UserAppointments");
            modelBuilder.Entity<UserAppointments>().HasOne<CompanyAppointmentTimes>().WithMany().HasPrincipalKey(caTimes => caTimes.Id).HasForeignKey(userAppoint => userAppoint.CompanyAppointmentTimeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_CompanyAppointmentTimes_UserAppointments");

            // Users

            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Users>().HasKey(user => user.Id).HasName("PK_Users");
            modelBuilder.Entity<Users>().Property(user => user.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.Surname).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.UserName).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.Email).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.Phone).HasColumnType("nvarchar(20)").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.Password).HasColumnType("nvarchar(200)").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.isActive).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.isAuthentication).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.CreationDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Users>().Property(user => user.LastUpdateDateTime).HasDefaultValueSql("CURRENT_TIMESTAMP()").HasColumnType("datetime").IsRequired(false);

        }
    }
}
