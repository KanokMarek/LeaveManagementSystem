using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "068ada9a-871e-45ea-abea-d17d246c865d", Name = "Employee", NormalizedName = "EMPLOYEE" },
                new IdentityRole { Id = "3028cec0-d14e-4bad-822b-f406ff5c8337", Name = "Supervisor", NormalizedName = "SUPERVISOR" },
                new IdentityRole { Id = "866bca51-26a7-41c7-9702-04d33608299c", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
            );
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "37b2c5dc-e7c3-495e-b21a-426c3187f083",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1990, 1, 1)
            });
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "866bca51-26a7-41c7-9702-04d33608299c", UserId = "37b2c5dc-e7c3-495e-b21a-426c3187f083" }
            );
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
