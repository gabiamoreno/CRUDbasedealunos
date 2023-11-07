using desafioAWSescola.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

public class AlunoMap : IEntityTypeConfiguration<alunomodel>
{
	public AlunoMap()
	{
	}

    public void Configure(EntityTypeBuilder<alunomodel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).IsRequired().HasMaxLength(260);
        builder.Property(x => x.Idade).IsRequired().HasMaxLength(2);
        builder.Property(x => x.NotaPrimeiroSemestre);
        builder.Property(x => x.NotaSegundoSemestre);
        builder.Property(x => x.Docente).HasMaxLength(260);
        builder.Property(x => x.Sala).HasMaxLength(3);
    }
}
