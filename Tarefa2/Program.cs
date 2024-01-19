class Program
{
    static void Main()
    {
        Console.Write("Operação (+, -, *, /): ");
        char operacao = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Digite o primeiro número: ");
        double n1;
        while (!double.TryParse(Console.ReadLine(), out n1))
        {
            Console.Write("Número inválido. Por favor, digite um número válido: ");
        }

        Console.Write("Digite o segundo número: ");
        double n2;
        while (!double.TryParse(Console.ReadLine(), out n2))
        {
            Console.Write("Número inválido. Por favor, digite um número válido: ");
        }

        double resultado = 0;
        switch (operacao)
        {
            case '+':
                resultado = n1 + n2;
                break;
            case '-':
                resultado = n1 - n2;
                break;
            case '*':
                resultado = n1 * n2;
                break;
            case '/':
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                }
                else
                {
                    Console.WriteLine("Não é possível fazer divisão por zero!!\n");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operação inválida. Escolha entre as seguintes opções: +, -, * ou /.");
                return;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
}
