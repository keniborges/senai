using Escola.Entidades;
using System.Collections.Generic;

namespace Escola.Repositorios.Interfaces
{
    public interface IProfessorRepository
    {
        bool Salvar(Professor professor);

        List<Professor> BuscarTodos();
    }
}
