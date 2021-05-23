using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public virtual DbSet<Course> Courses { get; set; } //Each DbSet we've included will become a table in our database. 
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollment { get; set; }

    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}