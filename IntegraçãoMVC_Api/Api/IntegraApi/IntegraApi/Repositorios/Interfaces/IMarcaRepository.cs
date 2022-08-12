using IntegraApi.Entidades;
using System.Collections.Generic;

namespace IntegraApi.Repositorios.Interfaces
{
    public interface IMarcaRepository
    {
        bool Salvar(Marca marca);        

        List<Marca> BuscarTodos();        

        Marca BuscarPorId(long id);        

        public bool Excluir(Marca marca);

    }
}
