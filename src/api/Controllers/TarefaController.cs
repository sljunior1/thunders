using Microsoft.AspNetCore.Mvc;
using thunders.tasks.api.Requests.Tarefas;
using thunders.tasks.application.Services.Tarefas;

namespace thunders.tasks.api.Controllers
{
    [ApiController]
    [Route("thunders/api/tarefas/")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;
        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet]
        [Route("pesquisar-todas-tarefas")]
        public IActionResult PesquisarTodasTarefas()
        {
            try
            {
                return Ok(_tarefaService.PesquisarTodasTarefas());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("pesquisar-por-tarefa")]
        public IActionResult PesquisarPorIdTarefa(Guid id)
        {
            try
            {
                var task = _tarefaService.PesquisarPorIdTarefa(id);

                if (task == null)
                {
                    return NotFound();
                }

                return Ok(task);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("criar")]
        public IActionResult CriarTarefa([FromBody] CriarTarefaRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest();
                }

                var tarefa = _tarefaService.CriarTarefa(request.Titulo, request.Descricao);

                return Ok(tarefa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("atualizar")]
        public IActionResult AtualizarTarefa([FromBody] AtualizarTarefaRequest request)
        {
            try
            {
                if (request == null)
                    return BadRequest();

                var tarefa = _tarefaService.AtualizarTarefa(request.Id, request.Titulo, request.Descricao, request.StatusTarefa);

                if (tarefa == null)
                    return NotFound();

                return Ok(tarefa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("excluir")]
        public IActionResult ExcluirTarefa(Guid id)
        {
            try
            {
                _tarefaService.ExcluirTarefa(id);

                return Ok("Tarefa removida");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
