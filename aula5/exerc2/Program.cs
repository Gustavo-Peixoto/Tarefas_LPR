Random numAleatorio = new Random();
int valorAleatorio = numAleatorio.Next(1,100);
int chute = 0;

do
{
    Console.Write("Chute o valor: ");
    chute = Convert.ToInt32(Console.ReadLine());
    if(chute > valorAleatorio)
    {
        Console.WriteLine("Chutou Alto!!");
    }
    else if(chute < valorAleatorio)
    {
        Console.WriteLine("Chutou Baixo!!");
    }
}
while(chute != valorAleatorio);

Console.WriteLine("Você Adivinhou O Numero!!!");