using Aula03.Contexto;
using Aula03.Entidades;
using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new SenaiContext();

            var escola = new Escola() {  Nome = "Senai" };
            context.Escola.Add(escola);
            context.SaveChanges();




        }
    }
}
