using JobPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobPlanner.Data
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
                new IdentityRole
                {
                    Id = "5e174d1e-2b9f-48fe-9561-1149894920f5",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                    UserName = "admin@localhost",
                    NormalizedUserName = "ADMIN@LOCALHOST",
                    Email = "admin@localhost",
                    NormalizedEmail = "ADMIN@LOCALHOST",
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "admin"),
                    Image = File.ReadAllBytes("wwwroot\\assets\\images\\users\\avatar-1.jpg"),
                    EmailConfirmed = true
                }
            );
            builder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "5e174d1e-2b9f-48fe-9561-1149894920f5",
                    UserId = "22d1a66c-ccd8-4c1e-8763-a896c287ea2c"
                }
            );
        }
        public DbSet<JobPlanner.Models.Location> Location { get; set; } = default!;
    }

}
