namespace exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Digite o nome do funcionario: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Digite o salario bruto do funcionario: ");
            funcionario.salario = Convert.ToInt32(Console.ReadLine());
            funcionario.Dadosfuncionarios();
        }
    }
}
