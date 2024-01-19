using System.Globalization;
class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o seu salário.\nSalário: ");
        double salario;
        while(!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out salario))
        {
            Console.WriteLine("Valor inválido, informe um valor válido: ");
        }
        
        if(salario < 1700)
        {
            double reajuste = 300.00;
            Console.WriteLine($"Salário atual: {salario}");
            Console.WriteLine($"Salário após reajuste: {salario+reajuste}");
        } else {
            double reajuste = 200.00;
            Console.WriteLine($"Salário atual: {salario}");
            Console.WriteLine($"Salário após reajuste: {salario + reajuste}");
        }
    }
}