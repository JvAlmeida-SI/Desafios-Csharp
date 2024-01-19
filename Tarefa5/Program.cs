class Program
{
    static void Main()
    {
        Console.Write("Informe a string que será contada: ");
        string contarVogais = Console.ReadLine();
        string contarVogaisFormatada = contarVogais.ToUpper();

        int contador = 0;
        foreach (char a in contarVogaisFormatada)
        {
            switch (a)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    contador++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"A quantidade de vogais é: {contador}");
    }
}