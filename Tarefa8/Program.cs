class Program
{
    static void Main()
    {
        int[] vetor = new int[10];
        int total = 0;

        Console.WriteLine("Digite dez números: ");
        for (int i = 0; i < 10; i++)
        {
            string numeroDoTeclado = Console.ReadLine();
            vetor[i] = Convert.ToInt32(numeroDoTeclado);
            total += vetor[i];
        }
        Console.Write($"Soma dos valores do vetor: {total}\n");
    }
}