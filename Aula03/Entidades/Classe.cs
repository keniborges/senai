using Aula03.Entidades.Enums;

namespace Aula03.Entidades
{
    public class Classe : BaseEntity
    {
        public SerieEnum Serie { get; set; }

        public long EscolaId { get; set; }

        public Escola Escola { get; set; }

        public long ProfessorId { get; set; }

        public Professor Professor { get; set; }
    }
}
