using System;

namespace Ejercicio2
{
  internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados caso = new ControlEmpresasEmpleados();

            Console.WriteLine($"Promedio por emplresa\n************************");
            caso.promedioSueldo();
            Console.WriteLine("");



            Console.WriteLine("Los delanteros de la liga\n***********************");
            caso.getSeo("Delantero");
            Console.WriteLine("");

            Console.WriteLine("Todos los jugadores de la liga\n***********************");
            caso.getJugadoresOrdenados();
            Console.WriteLine("");

            Console.WriteLine("Jugadores que cobran mas a menos\n*************************");
            caso.getJugadoresPorSueldo();
            Console.WriteLine("");

            Console.WriteLine("Ingrese el Id del club para ver su plantilla\n************\n1-Nacional\n2-Barcelona\n3-ManCity");
            string id = Console.ReadLine();
            try
            {
                int Empresa = int.Parse(id);
                caso.getEmpleadoPorClub(Empresa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ingrese un numero valido");
            }
        }
    }
}