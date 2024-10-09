namespace Atv___02
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Rm { get; set; }
        public string Email { get; set; }
        public DateTime Ano { get; set; }

        public Aluno(string nome, int rm, string email, DateTime ano)
        {
            Nome = nome;
            Rm = rm;
            Email = email;
            Ano = ano;

        }
    }
}
