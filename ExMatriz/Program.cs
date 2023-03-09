internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matriz = new double[5, 3];
        double mediaColuna;

        matriz = populaMatriz(matriz);

        mediaColuna = mediaColunas(matriz);

        imprimeMatriz(populaTerceiraColuna(matriz, mediaColuna));

        //Funções
        void imprimeMatriz(double[,] matriz)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($" | {matriz[linha, coluna]} | ");
                }
                Console.WriteLine();
            }
        }

        double[,] populaMatriz(double[,] matriz)
        {
            Random numero = new();

            for(int linha = 0; linha < 5; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    matriz[linha, coluna] = numero.NextDouble() * 100;
                }           
            }

            return matriz;
        }

        double mediaColunas(double[,] matriz)
        {
            double media = 0;

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    media += matriz[linha, coluna] ;
                }
            }

            return media /= 10;
        }

        double[,] populaTerceiraColuna(double[,] matriz, double media)
        {
            for(int coluna = 2; coluna == 2; coluna++)
            {
                for(int linha = 0; linha < 5; linha++)
                {
                    matriz[linha, coluna] = media;
                }
            }

            return matriz;
        }
    }
}