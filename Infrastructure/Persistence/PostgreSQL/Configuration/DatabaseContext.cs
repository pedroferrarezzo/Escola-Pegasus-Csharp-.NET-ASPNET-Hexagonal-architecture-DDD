using Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.PostgreSQL.Configuration
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        protected DatabaseContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbSet<Aluno>
        }
    }
}
