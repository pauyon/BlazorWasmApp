using BlazorWasmApp.Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmApp.Server.Infrastructure
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {

        }

        DbSet<Camera> Cameras => Set<Camera>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Camera>()
                .ToTable("Cameras", c => c.IsTemporal());

            base.OnModelCreating(modelBuilder);
        }
    }
}
