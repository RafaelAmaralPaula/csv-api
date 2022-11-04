using Microsoft.EntityFrameworkCore;

namespace Csv.Api.Models.Context
{
    public class MySqlContext : DbContext
    {

        public MySqlContext() { }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Temperature> Temperatures { get; set; }

    }
}