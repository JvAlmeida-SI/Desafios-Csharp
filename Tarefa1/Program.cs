class Program
{
    static void Main()
    {
        Console.Write("Escreva um número: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if(x % 2 == 0){
            Console.Write("Par\n");
        } else {
            Console.Write("Ímpar\n");
        }
    }
}