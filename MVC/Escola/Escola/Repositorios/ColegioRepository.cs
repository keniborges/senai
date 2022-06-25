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
                _context.Colegio.Add(colegio);
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

    }
}
