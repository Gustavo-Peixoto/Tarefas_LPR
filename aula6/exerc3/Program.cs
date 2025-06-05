using System;
using System.Net;
using System.Runtime.InteropServices;

class exerc3()
{

    static void Main()
    {
        cadastrarHeroi();
    }

    static void cadastrarHeroi()
    {

        bool end = false;
        int contador = 1;

        string nome1 = "", poder1 = "", nome2 = "", poder2 = "", nome3 = "", poder3 = "", nome4 = "", poder4 = "", nome5 = "", poder5 = "";
        int pontos1 = 0, pontos2 = 0, pontos3 = 0, pontos4 = 0, pontos5 = 0;

        while(contador < 6 && !end)
        {
            Console.WriteLine($"\nCadastro do Herói #{contador}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Poder: ");
            string poder = Console.ReadLine();
            Console.Write("Pontuação: ");
            int pontos = int.Parse(Console.ReadLine());

            if (contador == 1)
            {
                nome1 = nome; poder1 = poder; pontos1 = pontos;
            }
            else if (contador == 2)
            {
                nome2 = nome; poder2 = poder; pontos2 = pontos;
            }
            else if (contador == 3)
            {
                nome3 = nome; poder3 = poder; pontos3 = pontos;
            }
            else if (contador == 4)
            {
                nome4 = nome; poder4 = poder; pontos4 = pontos;
            }
            else if (contador == 5)
            {
                nome5 = nome; poder5 = poder; pontos5 = pontos;
            }

            contador++;

            Console.Write("Deseja colocar mais nomes?(s ou n)");
            string endQuestion = Console.ReadLine();
            if(endQuestion != "s") end = true;

        }
    }
}