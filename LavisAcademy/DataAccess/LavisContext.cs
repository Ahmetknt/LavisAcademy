using LavisAcademy.Entities;
using Microsoft.EntityFrameworkCore;

namespace LavisAcademy.DataAccess
{
    public class LavisContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMET;Database=LavisAcademy;Trusted_Connection=true; Integrated Security=True; TrustServerCertificate=True;");
        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EducationCoach> EducationCoaches { get; set; }

    }
}
