using Escola.Context;
using Escola.Entidades;
using Escola.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Escola.Repositorios
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly EscolaContext _context;

        public ProfessorRepository(EscolaContext context)
        {
            _context = context;
        }

        public bool Salvar(Professor professor)
        {
            try
            {
                _context.Professor.Add(professor);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Professor> BuscarTodos()
        {
            return _context.Professor.Include(c => c.Colegio).ToList();
        }
    }
}
