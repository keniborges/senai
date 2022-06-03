namespace Aula02.SalarioFuncionario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public decimal Salario { get; set; }

        public abstract decimal Bonificacao { get; protected set; }
    }
}
