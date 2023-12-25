using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

//using Microsoft.Identity.Client;
using CompanyWeb.Data.Configuration;
using CompanyWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWeb.Data.EF
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> contextOptions) : base(contextOptions)
        {
            //options.UseSqlServer("")
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionString[""].ConnectionString);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration
            //add-migration <name of migration>
            //remove-migration
            //update-database
            modelBuilder.ApplyConfiguration(new cCustomerConfiguration());
            modelBuilder.ApplyConfiguration(new cPostConfiguration());
            modelBuilder.ApplyConfiguration(new cProductConfiguration());
            modelBuilder.ApplyConfiguration(new dCustomerConfiguartion());
            modelBuilder.ApplyConfiguration(new dEmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new dFeedbackConfiguration());
            modelBuilder.ApplyConfiguration(new dPostConfiguration());
            modelBuilder.ApplyConfiguration(new dProductConfiguration());
            modelBuilder.ApplyConfiguration(new dQnAConfiguration());
            modelBuilder.ApplyConfiguration(new dRecuitmentConfiguration());
            modelBuilder.ApplyConfiguration(new dUserConfiguration());
            modelBuilder.ApplyConfiguration(new sSystemConfiguration());

            //modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("d_UserClaims");
            //modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("d_UserRoles").HasKey(x => new { x.RoleId, x.UserId });
            //modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("d_UserLogins").HasKey(x => x.UserId);
            //modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("d_RoleClaims");
            //modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("d_UserTokens").HasKey(x => x.UserId);
            base.OnModelCreating(modelBuilder);

            //Data seeding
            modelBuilder.Entity<dUser>().HasData(new dUser { ID = 1, Name = "Quản trị viên", Username = "admin", Password = "123$%^", CreatedDate = DateTime.Now, Status = 1 });

            //const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            //const string ROLE_ID = ADMIN_ID;
            //modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id=ROLE_ID, Name="Admin", MormalizedName="admin"});
            //var hasher=new PasswordHasher<User_In>
        }

        public static Guid ToGuid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }

        public DbSet<cProduct> cProducts { get; set; }
        public DbSet<cPost> cPosts { get; set; }
        public DbSet<cCustomer> cCustomers { get; set; }
        public DbSet<dQnA> dQnAs { get; set; }
        public DbSet<dProduct> dProducts { get; set; }
        public DbSet<dPost> dPosts { get; set; }
        public DbSet<dCustomer> dCustomers { get; set; }
        public DbSet<dRecuitment> dRecuitments { get; set; }
        public DbSet<dFeedback> dFeedbacks { get; set; }
        public DbSet<dEmployee> dEmployees { get; set; }
        public DbSet<sSystem> sSystems { get; set; }
        public DbSet<dUser> dUsers { get; set; }
    }
}