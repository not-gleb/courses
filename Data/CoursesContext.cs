using Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class CoursesContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CoursesDB;Trusted_Connection=True;");
        }
    }
}
