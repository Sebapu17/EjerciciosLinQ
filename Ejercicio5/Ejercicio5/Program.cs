internal class Program
{

    static void Main(string[] args)
    {

        List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int sumaTotalValoresParesMayoresAOcho = 0;
        int sumaTotalValoresParesMenoresAOcho = 0;

        foreach (var valor in valores)
        {
            if (valor % 2 == 0 && valor > 8)
            {
                sumaTotalValoresParesMayoresAOcho = sumaTotalValoresParesMayoresAOcho + valor;
            }
            else if (valor % 2 == 0 && valor <= 8)
            {
                sumaTotalValoresParesMenoresAOcho = sumaTotalValoresParesMenoresAOcho + valor;
            }
        }
        Console.WriteLine($"La suma total de los valores pares mayores a ocho es de: {sumaTotalValoresParesMayoresAOcho}");
        Console.WriteLine($"La suma total de los valores pares mayores a ocho es de: {sumaTotalValoresParesMenoresAOcho}");
        var valoresMayores = valores.Where(x => (x > 8) && (x % 2) == 0);

        Console.WriteLine(valoresMayores.Sum());
        var valoresMenores = valores.Where(x => (x <= 8) && (x % 2) == 0);

        Console.WriteLine(valoresMenores.Sum());

    }
}