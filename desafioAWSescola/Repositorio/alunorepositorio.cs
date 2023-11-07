using desafioAWSescola.Data;
using desafioAWSescola.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioAWSescola.Repositorio
{
    public class alunorepositorio : IAlunoRepositorio
    {
        private readonly infoalunos _dbContext;
        public alunorepositorio(infoalunos infoalunos)
        {
            _dbContext = infoalunos;
        }

        public async Task<alunomodel> BuscarPorId(int id)
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<alunomodel>> BuscarTodosAlunos()
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<alunomodel> Adicionar(alunomodel aluno)
        {
            await _dbContext.Alunos.AddAsync(aluno);
            await _dbContext.SaveChangesAsync();

            return aluno;
        }

        public async Task<alunomodel> Atualizar(alunomodel aluno, int id)
        {
            alunomodel alunoPorId = await BuscarPorId(id);
            
            if(alunoPorId == null)
            {
                throw new Exception($"Aluno para o ID: {id} não foi encontrado no banco de dados.");
            }

            alunoPorId.Nome = aluno.Nome;
            alunoPorId.Idade = aluno.Idade;
            alunoPorId.NotaPrimeiroSemestre = aluno.NotaPrimeiroSemestre;
            alunoPorId.NotaSegundoSemestre = aluno.NotaSegundoSemestre;
            alunoPorId.Docente = aluno.Docente;
            alunoPorId.Sala = aluno.Sala;

            _dbContext.Alunos.Update(alunoPorId);
            _dbContext.SaveChangesAsync();

            return alunoPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            alunomodel alunoPorId = await BuscarPorId(id);

            if (alunoPorId == null)
            {
                throw new Exception($"Aluno para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Alunos.Remove(alunoPorId);
            _dbContext.SaveChangesAsync();
            return true;
        }

        public Task<alunomodel> BuscarPorId()
        {
            throw new NotImplementedException();
        }
    }
}
