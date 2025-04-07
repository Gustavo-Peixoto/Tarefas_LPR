
Console.WriteLine("Digite a quantidade de numeros que deseja fazer a media aritmetica");
int quant_num= Convert.ToInt32(Console.ReadLine());

int cont = 0;
float num_soma = 0;
int par_cont = 0;
while(cont < quant_num)
{
    Console.WriteLine($"Escreva o {cont+1}º numero");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num % 2 == 0)
    {
        num_soma += num;
        par_cont++;
    }
    cont++;
}

float media = num_soma/par_cont;
Console.WriteLine($"A média aritmetica é: {media:F2}");