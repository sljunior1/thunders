using thunders.tasks.domain.Enum;

namespace thunders.tasks.domain.Entities
{
    public class Tarefa
    {
        public Guid Id { get; private set; }
        public string? Titulo { get; private set; }
        public string? Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public StatusTarefaEnum? StatusTarefa { get; private set; }

        public Tarefa(string? titulo, string? descricao)
        {
            NovaTarefa(titulo, descricao);
        }
        public void NovaTarefa(string? titulo, string? descricao)
        {
            Id = new Guid(Guid.NewGuid().ToString());
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            DataAtualizacao = null;
            StatusTarefa = StatusTarefaEnum.Criado;
        }
        public void AtualizarTitulo(string? titulo)
        {
            Titulo = titulo;
            DataAtualizacao = DateTime.Now;
        }
        public void AtualizarDescricao(string? descricao)
        {
            Descricao = descricao;
            DataAtualizacao = DateTime.Now;
        }
        public void AtualizarStatus(StatusTarefaEnum? status)
        {
            StatusTarefa = status;
        }
    }
}
