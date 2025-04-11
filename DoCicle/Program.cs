using System;
class Program
{
    static void Main(string[] args)
    {
        int contador = 0;

        while (contador < 3)
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        }

        Console.ReadKey();
    }
}