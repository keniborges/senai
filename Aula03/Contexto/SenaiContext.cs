using Aula03.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Contexto
{
    public class SenaiContext : DbContext
    {

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Professor> Professor { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai;User Id=postgres;Password=admin;");
        }


    }
}
