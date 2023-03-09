internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matriz = new double[5, 3];

        matriz = populaMatriz(matriz);

        mediaColunas(matriz);

        imprimeMatriz(matriz);

        //Funções
        void imprimeMatriz(double[,] matriz)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($" | {matriz[linha, coluna].ToString("F2")} | ");
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
                    matriz[linha, coluna] = (double) numero.Next(1000) / 100;
                }           
            }

            return matriz;
        }

        double[,] mediaColunas(double[,] matriz)
        {
            double media;

            for (int linha = 0; linha < 5; linha++)
            {
                media = (matriz[linha, 0] + matriz[linha, 1]) / 2;
                matriz[linha, 2] = media;
            }

            return matriz;
        }
    }
}