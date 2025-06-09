class exerc4
{
    static void Main()
    {
        int[,] A = new int[4, 4];
        int[,] B = new int[4, 4];
        int[,] Multip = new int[4, 4];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Para a matriz A digite o valor da linha {i} e o valor da coluna {j}:");
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Para a matriz B digite o valor da linha {i} e o valor da coluna {j}:");
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Multip[i, j] = A[i, 0] * B[0, j] + A[i, 1] * B[1, j] + A[i,2] * B[2,j];
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"[{Multip[i, j]}] ");
            }
            Console.WriteLine("");
        }
    }
}