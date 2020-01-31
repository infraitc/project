using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace code_first.Models
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<StudentContext>
    {
        public StudentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.100.101.92)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=STUDENT))); User Id=AMSSYS;Password=AMSSYS;");

            return new StudentContext(optionsBuilder.Options);
        }
    }
}