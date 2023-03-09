internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matriz = new int [5, 5];
        int media = 0;
        int somaLinha = 0;
        int somaColuna = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Random n = new Random();
                int aux = n.Next(100);
                matriz[i, j] = aux;
            }
        }

        //somas de linhas
        for (int c = 0; c < 5; c++)
        {
            somaLinha = somaLinha + matriz[0, c];
            Console.WriteLine(somaLinha);
        }
        //soma coluna
        for (int l = 0; l < 5; l++)
        {
            somaColuna = somaColuna + matriz[l, 0];
            Console.WriteLine(somaColuna);
        }


        //soma diagonal
        for (int l = 0;l < 5; l++)
        {
            for(int c = 0;c < 5; c++)
            {
                if (l == c)
                {
                    media = matriz[l, c] + matriz[l, c];
                }
            }
            Console.WriteLine(media);
        }
    }
}
