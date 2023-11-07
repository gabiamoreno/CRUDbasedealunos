namespace desafioAWSescola.Models
{
    public class alunomodel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public byte Idade { get; set; }
        public float? NotaPrimeiroSemestre { get; set; }
        public float? NotaSegundoSemestre { get; set; }
        public string? Docente { get; set; }
        public int? Sala { get; set; }
    }
}
