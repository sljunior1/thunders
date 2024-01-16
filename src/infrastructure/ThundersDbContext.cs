using Microsoft.EntityFrameworkCore;
using thunders.tasks.domain.Entities;
using thunders.tasks.infra.Configurations;

namespace thunders.tasks.infra
{
    public class ThundersDbContext : DbContext
    {
        public ThundersDbContext(DbContextOptions<ThundersDbContext> options) : base(options) { }
        public DbSet<Tarefa> Tarefas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TarefaConfiguration());
        }
    }
}
