using System.Globalization;

class exerc1
{
    public struct Produto
    {
        public string nome;
        public string codigo;
        public int preco;
        public int quantidade;
    }
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1} produto: ");
            produtos[i].nome = Console.ReadLine();
            Console.WriteLine($"Digite o codigo do {i + 1} produto: ");
            produtos[i].codigo = Console.ReadLine();
            Console.WriteLine($"Digite o preço do {i + 1} produto: ");
            produtos[i].preco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o quantidade do {i + 1} produto: ");
            produtos[i].quantidade = Convert.ToInt32(Console.ReadLine());
        }
        int resultado = 0;
        for (int i = 0; i < 3; i++)
        {
            resultado += produtos[i].quantidade * produtos[i].preco;
        }
        Console.WriteLine(resultado);
    }
}