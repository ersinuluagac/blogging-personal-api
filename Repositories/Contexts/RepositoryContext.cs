using Microsoft.EntityFrameworkCore;
using Repositories.Configs;

namespace Repositories.Contexts
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfig());
        }
    }
}
