using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=DESKTOP-UE10ANJ\\SQLEXPRESS;Initial Catalog=sms;User Id=sa;password=123;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

    }
}
