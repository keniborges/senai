﻿using Aula03.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Contexto
{
    public class SenaiContext : DbContext
    {        
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Aluno> Aluno { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=SenaiEscola;User Id=postgres;Password=admin;");
        }


    }
}
