using System; 
class Program
{
    static void Main(string[] args)
    {
        int contador = 0;

        do
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        } while (contador < 3);
        Console.ReadKey();
    }
}