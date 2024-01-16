using thunders.tasks.domain.Entities;

namespace thunders.tasks.domain.Interfaces
{
    public interface ITarefaRepository
    {
        void CriarTarefa(Tarefa obj);
        Tarefa? PesquisarPorIdTarefa(Guid id);
        List<Tarefa> PesquisarTodasTarefas();
        void AtualizarTarefa(Tarefa obj);
        void ExcluirTarefa(Guid id);
        int SaveChanges();
    }
}
