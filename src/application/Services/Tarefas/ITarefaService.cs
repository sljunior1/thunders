using thunders.tasks.domain.Entities;
using thunders.tasks.domain.Enum;

namespace thunders.tasks.application.Services.Tarefas
{
    public interface ITarefaService
    {
        List<Tarefa>? PesquisarTodasTarefas();
        Tarefa? PesquisarPorIdTarefa(Guid id);
        Tarefa? CriarTarefa(string? titulo, string? descricao);
        Tarefa? AtualizarTarefa(Guid id, string? titulo, string? descricao, StatusTarefaEnum statusTarefa);
        void ExcluirTarefa(Guid id);
    }
}
