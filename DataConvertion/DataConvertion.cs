using System;
class DataConvertion
{
    static void Main(string[] args)
    {
        double valorDouble = 12.78;
        int valorEntero = (int)valorDouble;
        string numeroTexto = "50";
        int numeroEntero = Convert.ToInt32(numeroTexto);

        Console.WriteLine($"Valor entero (casting): {valorEntero}");
        Console.WriteLine($"Número convertido: {numeroEntero}");

        Console.ReadKey();
    }
}