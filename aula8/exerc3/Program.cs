using System.Security.Cryptography.X509Certificates;

public struct Personagem
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}
public struct Equipe
{
    public string Nome;
    public string Poder;
    public int pontosTotais;
}
class exerc3
{
    static Personagem[] Times = new Personagem[5];
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("1 - Cadastrar os Heróis.");
            Console.WriteLine("2 - Selecionar a Equipe.");
            Console.WriteLine("3 - Exibir equipe.");
            Console.WriteLine("4 - Sair");
            int decisao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("________________________________________________________");
            switch (decisao)
            {
                case 1:
                    cadastrarHeroi();
                    break;
            }
        }
    }
    static void cadastrarHeroi()
    {
        Console.Clear();
        Console.WriteLine("Quantos Heróis deseja cadastrar?(Entre 3 a 5).");
        int Quant = Convert.ToInt32(Console.ReadLine());
        if (Quant < 3 || Quant > 5)
        {
            Console.WriteLine("Numero indisponivel.");
        }
        else
        {
            for (int i = 0; i < Quant; i++)
            {
                Console.Clear();
                Console.WriteLine($"Digite o nome do {i + 1} personagem: ");
                Times[i].Nome = Console.ReadLine();
                Console.WriteLine($"Digite o poder do {i + 1} personagem: ");
                Times[i].Poder = Console.ReadLine();
                Console.WriteLine($"Digite os pontos do {i + 1} personagem: ");
                Times[i].Pontuacao = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void selecionarEquipe()
    {
        
    }
}