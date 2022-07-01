using Escola.Context;
using Escola.Entidades;
using Escola.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Escola.Repositorios
{
    public class ColegioRepository : IColegioRepository
    {
        private readonly EscolaContext _context;

        public ColegioRepository(EscolaContext context)
        {
            _context = context;
        }

        public bool Salvar(Colegio colegio)
        {
            try
            {
                if (colegio.Id == 0)
                    _context.Colegio.Add(colegio);
                else
                    _context.Colegio.Update(colegio);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }            
        }

        public List<Colegio> BuscarTodos()
        {
            return _context.Colegio.Include(c => c.Endereco).ToList();
        }

        public Colegio BuscarPorId(long id)
        {
            return _context.Colegio.Include(c => c.Endereco).Where(c => c.Id == id).FirstOrDefault();
        }

        public bool Excluir(Colegio colegio)
        {
            try
            {
                _context.Colegio.Remove(colegio);
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
