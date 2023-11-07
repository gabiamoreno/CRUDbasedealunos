using desafioAWSescola.Models;
using Microsoft.EntityFrameworkCore;

public class infoalunos : DbContext
{
	public infoalunos(DbContextOptions<infoalunos> options)
		: base(options)
	{
	}
	public DbSet<alunomodel> Alunos { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new AlunoMap());

		base.OnModelCreating(modelBuilder);
	}
}
