using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    override protected void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "d2c00176-3ba2-4868-8dc3-6c1a3b0f0713",
            Name = "Employee",
            NormalizedName = "EMPLOYEE"
        }, new IdentityRole
        {
            Id = "86d767c0-3bab-48d8-a92d-ae9063dc00a3",
            Name = "Supervisor",
            NormalizedName = "SUPERVISOR"
        }, new IdentityRole
        {
            Id = "9c62fcfd-9a00-4617-b4c5-7141d0ac2b4d",
            Name = "Administrator",
            NormalizedName = "ADMINISTRATOR"
        }
        );
        var hasher = new PasswordHasher<ApplicationUser>();
        var adminUser = new ApplicationUser
        {
            Id = "4f7373cd-2764-4220-9d09-d35e32356aa8",
            Email = "admin@localhost.com",
            NormalizedEmail = "ADMIN@LOCALHOST.COM",
            NormalizedUserName = "ADMIN@LOCALHOST.COM",
            UserName = "admin@localhost.com",
            EmailConfirmed = true,
            FirstName = "Default",
            LastName = "Admin",
            DateOfBirth = new DateOnly(1998, 12, 30)
        };
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "P@ssword1");
        builder.Entity<ApplicationUser>().HasData(adminUser);

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "9c62fcfd-9a00-4617-b4c5-7141d0ac2b4d",
            UserId = "4f7373cd-2764-4220-9d09-d35e32356aa8"
        });
    }
    public DbSet<LeaveType> LeaveTypes { get; set; }
}
