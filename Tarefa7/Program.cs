class Program
{
    static void Main()
    {
        ContaCorrente conta = new ContaCorrente();
        double saldo = conta.saldo;
        string sair = "0";

        while(sair != "3")
        {
            Console.WriteLine("Digite sua opção:\n1 - Consultar Saldo\n2 - Realizar Saque\n3 - Sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    conta.consulta(saldo);
                    break;
                case "2":
                    saldo = conta.saque(saldo);
                    break;
            }
            sair = opcao;
        }
    }
}