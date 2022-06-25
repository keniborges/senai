using Aula03.Contexto;
using Aula03.Entidades;
using Aula03.Entidades.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Aula03
{
    class Program
    {

        private static SenaiContext _context;

        static void Main(string[] args)
        {
            _context = new SenaiContext();
            ChamarMenu();
        }

        private static void ChamarMenu()
        {
            Console.WriteLine("Escolha uma opção :");
            Console.WriteLine("1 - Cadastrar uma Escola");
            Console.WriteLine("2 - Cadastrar um Professor");
            Console.WriteLine("3 - Cadastrar uma Classe");
            Console.WriteLine("4 - Cadastrar um Aluno");
            Console.WriteLine("5 - Listar Alunos");
            Console.WriteLine("6 - Excluir Aluno");
            var escolhaMenu = Console.ReadLine();
            ExecutarEscolha(escolhaMenu);            
        }

        private static void ApresentarErro()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menu Inválido");
            Console.ResetColor();
            ChamarMenu();
        }

        private static void ExecutarEscolha(string escolhaMenu)
        {
            switch (escolhaMenu)
            {
                case "1":
                    CadastrarEscola();
                    break;
                case "2":
                    CadastrarProfessor();
                    break;
                case "3":
                    CadastrarClasse();
                    break;
                case "4":
                    CadastrarAluno();
                    break;
                case "5":
                    ListarAlunos();
                    ChamarMenu();
                    break;
                case "6":
                    ExcluirAluno();
                    break;
                default :
                    ApresentarErro();
                    break;
            }
        }

        #region Alunos

        private static void ExcluirAluno()
        {
            Console.WriteLine("Selecione o Aluno para Excluir :");
            ListarAlunos();
            var aluno = Convert.ToInt32(Console.ReadLine());
            var alunoExclusao = _context.Aluno.FirstOrDefault(c => c.Id == aluno);
            Console.ForegroundColor = ConsoleColor.Red;
            if (alunoExclusao == null)
            {                
                Console.WriteLine("Aluno não encontrado.");                
            }
            else
            {
                _context.Aluno.Remove(alunoExclusao);
                Console.WriteLine("Aluno Excluído Com Sucesso.");
            }
            Console.ResetColor();
        }

        private static void CadastrarAluno()
        {
            var aluno = new Aluno();
            Console.WriteLine("Digite o Nome do Aluno :");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Nascimento do Aluno (dd/mm/aaaa) :");
            aluno.Nascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o Cpf do Aluno (xxx.xxx.xxx-xx) :");
            aluno.Cpf = Console.ReadLine();
            ListarClasses();
            Console.WriteLine("Selecione a Classe do Aluno :");
            aluno.ClasseId = Convert.ToInt32(Console.ReadLine());
            SalvarAluno(aluno);
        }

        private static void SalvarAluno(Aluno aluno)
        {
            _context.Aluno.Add(aluno);
            _context.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Aluno Salvo Com Sucesso.");
            Console.ResetColor();
            ChamarMenu();
        }

        private static void ListarAlunos()
        {
            var alunos = _context.Aluno.Include(c => c.Classe).ThenInclude(d => d.Escola).ThenInclude(d => d.Professores).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Id} - {aluno.Nome}, Classe  : {aluno.Classe.Serie}, Escola : {aluno.Classe.Escola.Nome}");
            }
            Console.ResetColor();
        }

        #endregion

        #region Classe

        private static void ListarClasses()
        {
            var classes = _context.Classe.Include(c => c.Escola).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var classe in classes)
            {
                Console.WriteLine($"{classe.Id} - {classe.Serie}, Escola : {classe.Escola.Nome}");
            }
            Console.ResetColor();
        }

        private static void CadastrarClasse()
        {
            var classe = new Classe();
            Console.WriteLine("Digite a Série da Classe :");
            foreach (var serie in Enum.GetValues(typeof(SerieEnum)))
            {
                Console.WriteLine($"{(int)serie} - {serie}");
            }
            classe.Serie = (Entidades.Enums.SerieEnum)Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Selecione a escola:");
            ListarEscolas();
            classe.EscolaId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Selecione o professor :");
            ListarProfessores();
            classe.ProfessorId = Convert.ToInt32(Console.ReadLine());
            SalvarClasse(classe);
        }

        private static void SalvarClasse(Classe classe)
        {
            _context.Classe.Add(classe);
            _context.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Classe Salva Com Sucesso.");
            Console.ResetColor();
            ChamarMenu();
        }

        #endregion

        #region Professor

        private static void ListarProfessores()
        {
            var professores = _context.Professor.ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var professor in professores)
            {
                Console.WriteLine($"{professor.Id} - {professor.Nome}");
            }
            Console.ResetColor();
        }

        private static void CadastrarProfessor()
        {
            var professor = new Professor();
            Console.WriteLine("Digite o Nome do Professor :");
            professor.Nome = Console.ReadLine();
            Console.WriteLine("Selecione a escola de vínculo do Professor :");
            ListarEscolas();
            professor.EscolaId = Convert.ToInt32(Console.ReadLine());
            SalvarProfessor(professor);
        }

        private static void SalvarProfessor(Professor professor)
        {
            _context.Professor.Add(professor);
            _context.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Professor Salvo Com Sucesso.");
            Console.ResetColor();
            ChamarMenu();
        }

        #endregion

        #region Escola

        private static void ListarEscolas()
        {
            var escolas = _context.Escola.ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var escola in escolas)
            {
                Console.WriteLine($"{escola.Id} - {escola.Nome}");
            }
            Console.ResetColor();
        }


        private static void CadastrarEscola()
        {
            var escola = new Escola();
            var endereco = new Endereco();
            Console.WriteLine("Digite o Nome da Escola :");
            escola.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Rua da Escola");
            endereco.Rua = Console.ReadLine();
            Console.WriteLine("Digite o Bairro da Escola"); 
            endereco.Bairro = Console.ReadLine();
            Console.WriteLine("Digite a Cidade da Escola");
            endereco.Cidade = Console.ReadLine();
            Console.WriteLine("Digite o Estado da Escola");
            endereco.Estado = Console.ReadLine();            
            Console.WriteLine("Digite o Número do Endereço da Escola");
            endereco.Numero = Convert.ToInt16(Console.ReadLine());
            escola.Endereco = endereco;
            SalvarEscola(escola);
        }

        private static void SalvarEscola(Escola escola)
        {
            _context.Escola.Add(escola);
            _context.SaveChanges();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Escola Salva Com Sucesso.");
            Console.ResetColor();
            ChamarMenu();
        }

        #endregion


    }
}
