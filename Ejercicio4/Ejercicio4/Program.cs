using System;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int sumaTotal = 0;

        foreach (var valor in valores)
        {
            sumaTotal = sumaTotal + valor;
        }

        Console.WriteLine($"La suma to222tal es: {sumaTotal}");

        int sum = valores.Sum();
        Console.WriteLine("Parte 1 LINQ");
        Console.WriteLine(sum);

        int sumaTotalValoresPares = 0;

        foreach (var valor in valores)
        {
            if (valor % 2 == 0)
            {
                sumaTotalValoresPares = sumaTotalValoresPares + valor;
            }
        }

        Console.WriteLine($"La suma total de los valores pares es: {sumaTotalValoresPares}");

        //int sumaPares = valores.Where(x => (x % 2) == 0).Sum());
        //Console.WriteLine($"Parte 2 con linq es {sumaPares}");
        
           

       int sumaPares = valores.Where(x => (x % 2) == 0).Sum();
        Console.WriteLine(sumaPares);


    }
}




