using System.Runtime.Intrinsics.X86;
using Practica2LinQ;

internal class Program
{

    static void Main(string[] arg)
    {
        List<Persona> personas = new List<Persona>
    {
        new Persona {Nombre = "Juan", Edad = 25, Ciudad = "Lima"},
        new Persona {Nombre = "Maria", Edad = 32, Ciudad = "Bogota"},
        new Persona {Nombre = "Pedro", Edad = 35, Ciudad = "Madrid"},
        new Persona {Nombre = "Ana", Edad = 20, Ciudad = "Lima"},
        new Persona {Nombre = "Jose", Edad = 27, Ciudad = "Buenos Aires"}
    };

        var consulta = from p in personas
                       where p.Edad < 25 && p.Ciudad == "Lima"
                       orderby p.Nombre descending
                       select new { p.Nombre, p.Edad };

        foreach (var persona in consulta)
        {
            Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
        }


        //PARTE i.
        var mayoresDeTreinta = from p in personas
                               where p.Edad > 30 && p.Ciudad == "Bogota"
                               orderby p.Nombre descending
                               select new { p.Nombre, p.Edad };

        foreach (var persona in mayoresDeTreinta)
        {
            Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
        }

        //PARTE ii
        //Mostrar el nombre de todas las personas que tengan una edad entre 25 y 35 años, ordenadas por edad de forma ascendente.
        var entre = from p in personas
                    where p.Edad < 35 && p.Edad > 25
                    orderby p.Edad ascending
                    select p;
        foreach (var persona in entre)
        {
            Console.WriteLine($"{persona.Edad} -- {persona.Nombre}");
        }
    }

}