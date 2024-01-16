using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using thunders.tasks.domain.Entities;

namespace thunders.tasks.infra.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("Tarefa");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Titulo).HasColumnName("Titulo");
            builder.Property(t => t.Descricao).HasColumnName("Descricao");
            builder.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            builder.Property(t => t.DataAtualizacao).HasColumnName("DataAtualizacao");
            builder.Property(t => t.StatusTarefa).HasColumnName("StatusTarefa");
        }
    }
}
