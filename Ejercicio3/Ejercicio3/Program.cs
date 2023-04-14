using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("*********************************");
        Console.WriteLine("EJERCICIO 3");
        List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (var indice = 0; indice < valores.Count -1; indice=indice+1)
        {
            if (valores[indice] > valores[indice+1])
            {
                var valorTemporal = valores[indice];

                valores[indice] = valores[indice + 1];
                valores[indice + 1] = valorTemporal;
                indice = -1;
            }
        }

        foreach (var valorOrdenado in valores)
        {
            Console.WriteLine(valorOrdenado);
        }
        Console.WriteLine("***********RESPUESTA CON LINQ***********");

        List<int> valoresN = valores.OrderBy(valores => valores).ToList();
        foreach (int item in valoresN)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("TIENE 5 PUNTOS DE COMPLEJIDAD" +
            "FOR, .COUNT, IF(ADENTRO), FOREACH");


    }

}