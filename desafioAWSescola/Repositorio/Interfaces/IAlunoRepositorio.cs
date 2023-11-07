using desafioAWSescola.Models;

namespace desafioAWSescola.Data
{
    public interface IAlunoRepositorio
    {
        Task<List<alunomodel>> BuscarTodosAlunos();
        Task<alunomodel> BuscarPorId(int id);
        Task<alunomodel> Adicionar(alunomodel aluno);
        Task<alunomodel> Atualizar(alunomodel aluno, int id);
        Task<bool> Apagar(int id);
        Task<alunomodel> BuscarPorId();
    }
}
