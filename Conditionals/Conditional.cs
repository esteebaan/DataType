using System;
class Conditionals
{
    static void Main(string[] args)
    {
        int edad = 22;
        if (edad >= 18)
            Console.WriteLine("Es adulto");
        else
            Console.WriteLine("Es menor");

        Console.ReadKey();
    }
}