internal class Program
{
    private static void Main(string[] args)
    {
        float[,] matriz = new float[5, 3];
        float mediaColuna;

        matriz = populaMatriz(matriz);

        mediaColuna = mediaColunas(matriz);

        imprimeMatriz(populaTerceiraColuna(matriz, mediaColuna));

        //Funções
        void imprimeMatriz(float[,] matriz)
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

        float[,] populaMatriz(float[,] martriz)
        {
            Console.WriteLine("Digite 10 numeros inteiros ou reais para preeencher a matriz: ");

            for(int linha = 0; linha < 5; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    matriz[linha, coluna] = float.Parse(Console.ReadLine());
                }           
            }

            return matriz;
        }

        float mediaColunas(float[,] matriz)
        {
            float media = 0;

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    media += matriz[linha, coluna] ;
                }
            }

            return media /= 10;
        }

        float[,] populaTerceiraColuna(float[,] matriz, float media)
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