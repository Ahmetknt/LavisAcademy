using LavisAcademy.Entities;
using Microsoft.EntityFrameworkCore;

namespace LavisAcademy.DataAccess
{
    public class LavisContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=lavisacademy_;Persist Security Info=True;User ID=lavisacademy_;Password=LavisAcademy+;Trust Server Certificate=True");
        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EducationCoach> EducationCoaches { get; set; }

    }
}
