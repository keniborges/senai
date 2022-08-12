using IntegraApi.Context;
using IntegraApi.Entidades;
using IntegraApi.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IntegraApi.Repositorios
{
    public class ModeloRepository : IModeloRepository
    {
        private readonly IntegraContext _context;

        public ModeloRepository(IntegraContext context)
        {
            _context = context;
        }

        public bool Salvar(Modelo modelo)
        {
            try
            {
                if (modelo.Id == 0)
                    _context.Modelo.Add(modelo);
                else
                    _context.Modelo.Update(modelo);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Modelo> BuscarTodos()
        {
            return _context.Modelo.ToList();
        }

        public List<Modelo> BuscarPorMarcaId(long marcaId)
        {
            return _context.Modelo.Include(c => c.Marca).Where(c => c.MarcaId == marcaId).ToList();
        }

        public bool Excluir(Modelo modelo)
        {
            try
            {
                _context.Modelo.Remove(modelo);
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
