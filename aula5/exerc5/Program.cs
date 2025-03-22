int hours = 0;

while(true)
{
    Console.Write("Insira a quantidade de horas que serão treinadas por dia: ");
    hours = Convert.ToInt32(Console.ReadLine());

    if(hours > 24)
    {
        Console.WriteLine("Você não Consegue treinar dois dias em um cara.");
    }
    else
    {
        break;
    }
}

int horas_soma = 0;
int dias = 0;
float semanas = 0;
int mes = 0;

while(horas_soma < 1000)
{
    horas_soma += hours;
    dias++;
    if(dias == 5)
    {
        semanas++;
        dias = 0;
    }
    if(semanas >= 4.5)
    {
        mes++;
        semanas = 0;
    }
}
Console.WriteLine($"meses: {mes}\nSemanas: {semanas}\nDias: {dias}");