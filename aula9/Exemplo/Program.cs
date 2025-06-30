using System.Collections.Generic;

class Exemplo
{
    static void Main()
    {
        List<int> num = new List<int> { 1, 2, 3, 4, 5 };
        num.Add(4);
        num.Insert(3, 7);
        if (num.Contains(8))
        {
            Console.WriteLine("Tem oito");
        }
        else
        {
            Console.WriteLine("Não tem oito");
        }
        int cont3 = 0;
        int cont = 0;
        foreach (int numero in num)
        {
            if (numero > 4)
            {
                cont++;
            }
            if (numero == 3)
            {
                cont3++;
            }
        }
        Console.WriteLine($"Tem {cont} numeros maiores que 4");
        num.Remove(2);
        while (num.Contains(4))
        {
            num.Remove(4);
        }
        foreach (int numero in num)
        {
            Console.Write($"{numero} ");   
        }
    }
}
