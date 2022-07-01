using Escola.Entidades;
using System.Collections.Generic;

namespace Escola.Repositorios.Interfaces
{
    public interface IProfessorRepository
    {
        bool Salvar(Professor professor);

        bool Excluir(Professor professor);

        Professor BuscarPorId(long id);

        List<Professor> BuscarTodos();
    }
}
