using desafioAWSescola.Data;
using desafioAWSescola.Models;
using Microsoft.AspNetCore.Mvc;

namespace desafioAWSescola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<alunomodel>>> BuscarTodosAlunos() 
        {
            List<alunomodel> alunos = await _alunoRepositorio.BuscarTodosAlunos();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<alunomodel>>> BuscarPorId(int id)
        {
            alunomodel aluno = await _alunoRepositorio.BuscarPorId(id);
            return Ok(aluno);
        }

        [HttpPost]
        public async Task<ActionResult<alunomodel>> Cadastrar([FromBody] alunomodel alunomodel)
        {
            alunomodel aluno = await _alunoRepositorio.Adicionar(alunomodel);
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<alunomodel>> Atualizar([FromBody] alunomodel alunomodel, int id)
        {
            alunomodel.Id = id;
            alunomodel aluno = await _alunoRepositorio.Atualizar(alunomodel, id);
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<alunomodel>> Apagar(int id)
        {
            bool apagado = await _alunoRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
