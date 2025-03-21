using System.Drawing;

int num_escolha = 0;
string key = "";
while(key != "Enter")
{
    switch(num_escolha)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("| Escolha Sua Classe: |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| Guerreiro           |");
            Console.ResetColor();
            Console.WriteLine("| Mago                |");
            Console.WriteLine("| Arqueira            |");
        break;

        case 1:
            Console.Clear();
            Console.WriteLine("| Escolha Sua Classe: |");
            Console.WriteLine("| Guerreiro           |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| Mago                |");
            Console.ResetColor();
            Console.WriteLine("| Arqueira            |");
        break;

        case 2:
            Console.Clear();
            Console.WriteLine("| Escolha Sua Classe: |");
            Console.WriteLine("| Guerreiro           |");
            Console.WriteLine("| Mago                |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| Arqueira            |");
            Console.ResetColor();
        break;
    }

    key = Convert.ToString(Console.ReadKey().Key);
    if(key == "DownArrow") num_escolha++;
    if(key == "UpArrow") num_escolha--;

    if(num_escolha == -1) num_escolha = 2;
    if(num_escolha == 3) num_escolha = 0;

}
Console.ForegroundColor = ConsoleColor.Red;
if (num_escolha == 0)
{
    Console.Clear();
    Console.WriteLine("Voce é Guerreiro!");
    Console.WriteLine("Atributos:\nAtaque Pesado;\nDefesa Total.");
}
else if(num_escolha == 1)
{
    Console.Clear();
    Console.WriteLine("Voce é um Mago!");
    Console.WriteLine("Atributos:\nBola De Fogo;\nEscudo De Gelo.");
}
else
{
    Console.Clear();
    Console.WriteLine("Voce é Arqueira!");
    Console.WriteLine("Atributos:\nFlecha Precisa;\nDisparo Triplo.");
}
Console.ResetColor();

