using thunders.tasks.domain.Entities;
using thunders.tasks.domain.Enum;
using thunders.tasks.domain.Interfaces;

namespace thunders.tasks.application.Services.Tarefas
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public Tarefa? AtualizarTarefa(Guid id, string? titulo, string? descricao, StatusTarefaEnum statusTarefa)
        {
            try
            {
                var tarefa = _tarefaRepository.PesquisarPorIdTarefa(id);

                if (tarefa == null)
                    return null;

                tarefa.AtualizarTitulo(titulo);
                tarefa.AtualizarDescricao(descricao);
                tarefa.AtualizarStatus(statusTarefa);

                _tarefaRepository.AtualizarTarefa(tarefa);
                _tarefaRepository.SaveChanges();

                return tarefa;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Tarefa? CriarTarefa(string? titulo, string? descricao)
        {
            try
            {
                Tarefa tarefa = new Tarefa(titulo, descricao);
                _tarefaRepository.CriarTarefa(tarefa);
                _tarefaRepository.SaveChanges();

                return tarefa;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void ExcluirTarefa(Guid id)
        {
            try
            {
                _tarefaRepository.ExcluirTarefa(id);
                _tarefaRepository.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Tarefa? PesquisarPorIdTarefa(Guid id)
        {
            try
            {
                return _tarefaRepository.PesquisarPorIdTarefa(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Tarefa>? PesquisarTodasTarefas()
        {
            try
            {
                var tarefas = _tarefaRepository.PesquisarTodasTarefas();

                if (tarefas == null)
                    return null;

                return tarefas.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
