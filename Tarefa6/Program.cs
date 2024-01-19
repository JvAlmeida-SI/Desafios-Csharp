class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] alturas = new double[5];
        int posicaoNome = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o nome do {i+1}° aluno");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite a altura do {i+1}° aluno");
            string alturaString = Console.ReadLine();
            double.TryParse(alturaString, out alturas[i]);
            
            double maiorAltura = 0;
            if(alturas[i] > maiorAltura)
            {
                maiorAltura = alturas[i];
                posicaoNome = i;
            }
        }
        Console.WriteLine($"O aluno com a maior altura é: {nomes[posicaoNome]}");
    }
}