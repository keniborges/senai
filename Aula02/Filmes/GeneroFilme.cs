using System.ComponentModel.DataAnnotations;

namespace Aula02.Filmes
{
    public enum GeneroFilme
    {
        [Display(Name = "Terror")]
        Terror,
        [Display(Name = "Romance")]
        Romance,
        [Display(Name = "Ação")]
        Acao,
        [Display(Name = "Comédia")]
        Comedia

    }
}
