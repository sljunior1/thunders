using Microsoft.EntityFrameworkCore;
using thunders.tasks.domain.Entities;
using thunders.tasks.domain.Interfaces;

namespace thunders.tasks.infra.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        internal ThundersDbContext _dbContext;
        internal DbSet<Tarefa> dbSet;
        public TarefaRepository(ThundersDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<Tarefa>();
        }
        public void CriarTarefa(Tarefa obj)
        {
            dbSet.Add(obj);
        }
        public List<Tarefa> PesquisarTodasTarefas()
        {
            try
            {
                return dbSet.ToList();
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
                return dbSet.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirTarefa(Guid id)
        {
            try
            {
                var entidade = dbSet.Find(id);

                if (entidade != null)
                    dbSet.Remove(entidade);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
        public void AtualizarTarefa(Tarefa obj)
        {
            dbSet.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }
    }
}
