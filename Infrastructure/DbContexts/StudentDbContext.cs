using Microsoft.EntityFrameworkCore;
using CampusOne.Domain.Entitys.Student;

namespace Infrastructure.DbContexts
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<StudentEntity> Student { get; set; } 
    }
}
