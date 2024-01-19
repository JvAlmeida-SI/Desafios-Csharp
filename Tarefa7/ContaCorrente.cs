public class ContaCorrente
{
    private int IDdaConta;
    private string nomeDoCorrentista;
    public double saldo = 650.0;

    public double saque (double saldoConta)
    {
        Console.Write("Insira o valor do saque a ser realizado: ");
        double valor = 0;
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Informe um valor válido para sacar: ");
        }
        if(valor > saldoConta)
        {
            Console.Write("Saldo insuficiente!\n");
        } else 
            {
                saldoConta = saldoConta - valor;
            }
            return saldoConta;
    }

    public void consulta (double saldo)
    {
        Console.WriteLine($"O saldo da sua conta é: {saldo}");
    }
}