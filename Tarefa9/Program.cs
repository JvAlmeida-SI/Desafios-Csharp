class Program
{
    public string processarLinha(string linha)
    {
        linha = "Salário: " + linha;
        int indicePonto1 = linha.IndexOf(";");
        int indicePonto2 = linha.IndexOf(";", indicePonto1+1);
        linha = linha.Insert(indicePonto1+1, "Funcionário: ");
        linha = linha.Insert(indicePonto2+14, "Cargo: ");
        linha = linha.Replace(";", " - ");
        return linha;
    }
    public void lerArquivo(){
        string caminho = "/home/joao/Área de Trabalho/SmartConsulting/06. C Sharp/Coding/Tarefa9/csvFuncionarios.csv";
        using(StreamReader ler = new StreamReader(caminho))
        {
            while (!ler.EndOfStream)
            {
                string linha = ler.ReadLine();
                linha = processarLinha(linha);
                Console.WriteLine(linha);
            }
        }

    }

    static void Main()
    {
        Program imprimirCSV = new Program();
        imprimirCSV.lerArquivo();
    }
}