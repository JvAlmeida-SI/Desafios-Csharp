class Program
{
    static void Main()
    {
        int[,] matriz = {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
        
        string valorString = " ";

        // Alimentando a primeira matriz
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Insira o valor que será inserido na linha {i} e na coluna {j}");
                valorString = Console.ReadLine();
                int.TryParse(valorString, out matriz[i, j]);
            }
        }

        // Imprimindo a primeira matriz
        Console.WriteLine("\nImpressão da matriz: \n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.Write("\n");
        }

        // Criando e incrementando a matriz com a linha ordenada
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int[] linha = new int[matriz.GetLength(1)];
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                linha[j] = matriz[i, j];
            }

            Array.Sort(linha);

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = linha[j];
            }
        }

        //Imprimindo a matriz com as linhas ordenadas
        Console.WriteLine("\nImpressão da matriz: \n");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.Write("\n");
        }
    }
}