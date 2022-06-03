using Aula02.Alunos;
using Aula02.Calculadoras;
using Aula02.Combustiveis;
using Aula02.Cortinas;
using Aula02.Filmes;
using Aula02.SalarioFuncionario;
using Aula02.SalarioFuncionario.PadraoProjeto;
using System;
using System.Collections.Generic;

namespace Aula02
{
    class Program
    {



        static void Main(string[] args)
        {

            #region Idade Média dos Alunos

            //var alunos = new List<Aluno>();
            //alunos.Add(new Aluno() { Nome = "Pedro", Nascimento = new DateTime(2020, 01, 15) });
            //alunos.Add(new Aluno() { Nome = "Maria", Nascimento = new DateTime(2020, 05, 28) });

            //var infAlunos = new InformacoesAlunos();
            //var idadeMedia = infAlunos.IdadeMedia(alunos);

            #endregion

            #region Calculadora 

            //var calc = new Calculadora();
            //Console.WriteLine("Digite o valor A :");
            //var valorA = Console.ReadLine();
            //Console.WriteLine("Digite o valor B :");
            //var valorB = Console.ReadLine();
            //Console.WriteLine("Digite a operação (+, -, *, /) :");
            //var operacao = Console.ReadLine();
            //switch (operacao)
            //{
            //    case "+":
            //        Console.WriteLine(calc.Adicionar(Convert.ToDecimal(valorA), Convert.ToDecimal(valorB)));
            //        break;
            //    case "-":
            //        Console.WriteLine(calc.Subtrair(Convert.ToDecimal(valorA), Convert.ToDecimal(valorB)));
            //        break;
            //    case "*":
            //        Console.WriteLine(calc.Multiplicar(Convert.ToDecimal(valorA), Convert.ToDecimal(valorB)));
            //        break;
            //    case "/":
            //        Console.WriteLine(calc.Dividir(Convert.ToDecimal(valorA), Convert.ToDecimal(valorB)));
            //        break;
            //}
            #endregion

            #region Filme

            //var filme = new Filme() { Nome = "Top Gun Maverick", IdadeIndicativa = 16, Genero = GeneroFilme.Acao };
            //var usuario = new Usuario() {  Nome = "Keni", Idade = 18 };

            //var permissaoUsuario = new ValidarPermissaoUsuario();
            //var haPermissao = permissaoUsuario.Validar(usuario, filme);
            //if (haPermissao)
            //    Console.WriteLine("Usuário Tem Permissão");
            //else
            //    Console.WriteLine("Usuário Sem Permissão");
            //Console.ReadKey();

            #endregion

            #region Custo Cortina

            Console.WriteLine("Quantos Metros de Cortina usará? :");
            var metrosUtilizados = Console.ReadLine();
            Console.WriteLine("Qual modelo de Cortina você usará?\n\n 0 : Voal\n 1: Persiana\n 2 : Rolo\n 3 : Romana\n");
            var tipo = Console.ReadLine();

            var custo = new CustoCortina();
            decimal valor = 0;
            switch (tipo)
            {
                case "0":
                    valor = custo.CalcularCusto(TipoCortina.Voal, Convert.ToInt16(metrosUtilizados));
                    break;
                case "1":
                    valor = custo.CalcularCusto(TipoCortina.Persiana, Convert.ToInt16(metrosUtilizados));
                    break;
                case "2":
                    valor = custo.CalcularCusto(TipoCortina.Rolo, Convert.ToInt16(metrosUtilizados));
                    break;
                case "3":
                    valor = custo.CalcularCusto(TipoCortina.Romana, Convert.ToInt16(metrosUtilizados));
                    break;
            }
            Console.WriteLine("O valor total seria de : " + valor);
            Console.ReadLine();


            #endregion
        }
    }
}
