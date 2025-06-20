using APDB_Kolokwium_template.Models;
using Microsoft.EntityFrameworkCore;

namespace APDB_Kolokwium_template.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Enrollment> Enrollments { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    
    public AppDbContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var students = new List<Student>
        {
            new()
            {
                ID = 1,
                FirstName = "Anna",
                LastName = "Nowak",
                Email = "anna.nowak@example.eu"
                
            },
            new()
            {
                ID = 2,
                FirstName = "Tomasz",
                LastName = "Wiśniewski",
                Email = "tomasz.w@example.edu"
            }
        };

        var courses = new List<Course>
        {
            new()
            {
                ID = 101,
                Title = "Wprowadzenie do Algorytmów",
                Teacher = "dr Kowalski"
            },
            new()
            {
                ID = 102,
                Title = "Bazy Danych",
                Teacher = "mgr Nowicka"
            }
        };

        var enrollments = new List<Enrollment>
        {
            new()
            {
                Student_ID = 1,
                Course_ID = 101,
                EnrollmentDate = new DateTime(2024, 10, 01, 10, 0, 0),
            },
            new()
            {
                Student_ID = 2,
                Course_ID = 102,
                EnrollmentDate = new DateTime(2024, 10, 02, 9, 30, 0),
            }
        };
        
        modelBuilder.Entity<Student>().HasData(students);
        modelBuilder.Entity<Course>().HasData(courses);
        modelBuilder.Entity<Enrollment>().HasData(enrollments);
    }
    
}