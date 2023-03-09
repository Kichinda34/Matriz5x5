internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        int somaDiagonal = 0;
        int somaInversa = 0;
        Random n = new Random();

        //Somar valores na matriz
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                matriz[l, c] = n.Next(1000);
            }
        }

        //somas de linhas
        Console.WriteLine("Soma das colunas...");
        for (int l = 0; l < matriz.GetLength(1); l++)
        {
            Console.WriteLine("A soma das linha [" + l + "]= ");
            int somaLinha = 0;
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                somaLinha += matriz[l, c];
            }
            Console.WriteLine(somaLinha);
        }

        //soma de colunas
        Console.WriteLine("Soma das colunas...");
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
            Console.WriteLine("A soma das Colunas [" + c + "]= ");
            int somaColuna = 0;
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                somaColuna += matriz[l, c];
            }
            Console.WriteLine(somaColuna);
        }

        //soma de diagonais
        Console.WriteLine("Soma da Diagonal Principal...");

        for (int c = 0; c < matriz.GetLength(1); c++)
        {
            somaDiagonal += matriz[c, c];
        }
        Console.WriteLine(somaDiagonal);

        //Soma da Diagonal Secundaria
        Console.WriteLine("Soma da Diagonal Secundária...");
        for (int c = 0; c < matriz.GetLength(1); c++)
        {
            somaInversa += matriz[c, matriz.GetLength(1) - c - 1];
        }
        Console.WriteLine(somaInversa);

        //impressão da Matriz
        Console.WriteLine();
        for (int l = 0; l < matriz.GetLength(0); l++)
        {
            for (int c = 0; c < matriz.GetLength(1) - 1; c++)
            {
                Console.Write("\tMat[" + l + "][" + c + "] "+ matriz[l, c].ToString("d4"));
            }
            Console.WriteLine();
        }
    }
}