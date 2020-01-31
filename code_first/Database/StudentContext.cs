using Microsoft.EntityFrameworkCore;

namespace code_first.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
    }
}