Console.Write("Digite um numero: ");
int num = Convert.ToInt32(Console.ReadLine());
int num_quadrado = num*num;
int soma = 0;

while(num_quadrado > 0)
{
    soma += num_quadrado % 10;
    num_quadrado /= 10;
}

Console.WriteLine(soma);