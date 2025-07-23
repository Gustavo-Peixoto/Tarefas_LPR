using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Dictionary<string, int> Idades = new();

        Console.Write("Digite quantas pessoas quer registrar: ");
        int X = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < X; i++)
        {
            Console.Write("Digite qual nome deseja adicionar: ");
            string nomeAdicionado = Console.ReadLine();
            Idades.Add(nomeAdicionado, 0);
            Console.Write("Digite qual idade deseja adicionar par esse nome: ");
            int idadeAdicionada = Convert.ToInt32(Console.ReadLine());
            Idades[nomeAdicionado] = idadeAdicionada;
        }

        int somador = 0;
        foreach (var x in Idades)
        {
            somador += x.Value;
        }

        float media = somador / Idades.Count;

        foreach (var x in Idades)
        {
            if (x.Value > media) Console.WriteLine($"O {x.Key} esta acima da media com {x.Value} anos");
        }

        int maior = 0;
        int menor = 1000;
        string nomeMaior = "";
        string nomeMenor = "";

        foreach (var x in Idades)
        {
            if (x.Value > maior)
            {
                maior = x.Value;
                nomeMaior = x.Key;
            }
            if (x.Value < menor)
            {
                menor = x.Value;
                nomeMenor = x.Key;
            }
        }

        Console.WriteLine($"O nome do que tem a maior idade é {nomeMaior} e do que tem menor idade é {nomeMenor}");

        Console.Write("Digite o valor que deseja remover: ");
        int y = Convert.ToInt32(Console.ReadLine());

        foreach (var x in Idades)
        {
            if (x.Value == y) Idades.Remove(x.Key);
        }

        foreach (var x in Idades)
        {
            Console.WriteLine($"Nome: {x.Key}, Idade: {x.Value}");
        }
    }
}