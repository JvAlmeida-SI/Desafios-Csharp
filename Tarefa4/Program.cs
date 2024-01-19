using System;
using System.IO;
using System.Globalization;

class Program
{
    static double CalcularIMC (double peso, double altura){
        double resultadoFinal = peso/(altura*altura);

        return resultadoFinal;
    }
    static void SalvarDadosEmArquivo(string nome, int idade, double peso, double altura, double imc, string resultado)
    {
        string caminho = "/home/joao/Área de Trabalho/SmartConsulting/06. C Sharp/Coding/Tarefa4/imc.txt";

        using (StreamWriter escrever = new StreamWriter(caminho, true))
        {
            escrever.WriteLine($"Nome: {nome}");
            escrever.WriteLine($"Idade: {idade}");
            escrever.WriteLine($"Peso: {peso.ToString(CultureInfo.InvariantCulture)}");
            escrever.WriteLine($"Altura: {altura.ToString(CultureInfo.InvariantCulture)}");
            escrever.WriteLine($"IMC: {imc.ToString("F0", CultureInfo.InvariantCulture)}");
            escrever.WriteLine($"Resultado: {resultado}");
            escrever.WriteLine("------------------------------------------------");
        }
    }
    static void ImprimirDadosDoArquivo()
    {
        string caminho = "/home/joao/Área de Trabalho/SmartConsulting/06. C Sharp/Coding/Tarefa4/imc.txt";
        try
        {
            using (StreamReader lerArquivo = new StreamReader(caminho))
            {
                while (!lerArquivo.EndOfStream)
                {
                    string linha = lerArquivo.ReadLine();
                    Console.WriteLine(linha);
                }
            }
        }
        catch (FileNotFoundException){ Console.WriteLine($"Arquivo não encontrado: {caminho}"); }
        catch (Exception ex){ Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}"); }
    }

    static void Main()
    {
        Console.Write("N - Novo\nC - Consultar\nS - Sair\nInforme uma operação: ");
        string operacao = Console.ReadLine();

        switch(operacao.ToUpper())
        {
            case "N":
                Console.Write("\nInforme o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Informe a idade: ");
                int idade;
                while (!int.TryParse(Console.ReadLine(), out idade))
                {
                    Console.Write("Erro. Informe uma idade válida: ");
                }

                Console.Write("Informe o peso: ");
                double peso;
                while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
                {
                    Console.Write("Erro. Informe um peso válido: ");
                }

                Console.Write("Informe a altura(em metros): ");
                double altura;
                while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out altura))
                {
                    Console.Write("Erro. Informe uma altura válida: ");
                }
                Console.Write("\nPressione uma tecla para continuar");
                Console.ReadLine();

                double imc = CalcularIMC(peso, altura);
                string resultado;

                if(imc < 25 && imc > 15) { resultado = "Peso normal"; }
                else if( imc < 16) { resultado = "Magresa grave"; }
                else if( imc > 24 && imc < 30) { resultado = "Sobrepeso"; }
                else { resultado = "Obeso"; }

                SalvarDadosEmArquivo(nome, idade, peso, altura, imc, resultado);
                break;
            case "C":
                Console.Write("\n");
                ImprimirDadosDoArquivo();
                Console.Write("\nPressione uma tecla para continuar");
                Console.ReadLine();
                break;
            case "S":
                break;

            default:
                Console.WriteLine("Operação inválida.");
                return;
        }
    }
}