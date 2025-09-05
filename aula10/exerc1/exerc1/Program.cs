namespace exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();
            retangulo1.Altura = 5;
            retangulo1.Largura = 5;
            Console.WriteLine($"Perimetro do retangulo: {retangulo1.calcPerimetro()}");
            Console.WriteLine($"Area do retangulo: {retangulo1.calcArea()}");
        }
    }
}
