namespace Aula03.Entidades
{
    public class Aluno
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public long ProfessorId { get; set; }
        public Professor Professor { get; set; }

    }
}
