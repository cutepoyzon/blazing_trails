using BlazingTrails.Api.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazingTrails.Api.Persistence
{
    public class BlazingTrailsContext : DbContext
    {
        public BlazingTrailsContext(DbContextOptions<BlazingTrailsContext> options) : base(options)
        {

        }

        public DbSet<Trail> Trails => Set<Trail>();
        public DbSet<RouteInstruction> RouteInstructions => Set<RouteInstruction>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TrailConfig());
            modelBuilder.ApplyConfiguration(new RouteInstructionConfig());
        }
    }
}
