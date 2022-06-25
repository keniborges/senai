using Escola.Entidades;
using System.Collections.Generic;

namespace Escola.Repositorios.Interfaces
{
    public interface IColegioRepository
    {
        bool Salvar(Colegio colegio);

        List<Colegio> BuscarTodos();
    }
}
