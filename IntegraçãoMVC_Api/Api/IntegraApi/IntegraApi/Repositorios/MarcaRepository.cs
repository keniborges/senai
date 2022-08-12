using IntegraApi.Context;
using IntegraApi.Entidades;
using IntegraApi.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IntegraApi.Repositorios
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly IntegraContext _context;

        public MarcaRepository(IntegraContext context)
        {
            _context = context;
        }

        public bool Salvar(Marca marca)
        {
            try
            {
                if (marca.Id == 0)
                    _context.Marca.Add(marca);
                else
                    _context.Marca.Update(marca);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Marca> BuscarTodos()
        {
            return _context.Marca.ToList();
        }

        public Marca BuscarPorId(long id)
        {
            return _context.Marca.Where(c => c.Id == id).FirstOrDefault();
        }

        public bool Excluir(Marca marca)
        {
            try
            {
                _context.Marca.Remove(marca);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}
