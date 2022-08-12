using IntegraApi.Entidades;
using System.Collections.Generic;

namespace IntegraApi.Repositorios.Interfaces
{
    public interface IModeloRepository
    {
        bool Salvar(Modelo modelo);        

        List<Modelo> BuscarTodos();        

        List<Modelo> BuscarPorMarcaId(long marcaId);        

        bool Excluir(Modelo modelo);

    }
}
