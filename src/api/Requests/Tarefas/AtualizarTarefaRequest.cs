using thunders.tasks.domain.Enum;

namespace thunders.tasks.api.Requests.Tarefas
{
    public class AtualizarTarefaRequest
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefaEnum StatusTarefa { get; set; }
    }
}
