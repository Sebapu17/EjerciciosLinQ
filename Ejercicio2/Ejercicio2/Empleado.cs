using System;
namespace Ejercicio2
{
	public class Empleado
	{
		public int Id { get; set; }
		public string? Nombre { get; set; }
		public string? Puesto { get; set; }
		public int Sueldo { get; set; }
		public int EmpresaID { get; set; }
		public void getDatosEmpleado()
		{
			Console.WriteLine($"El jugador {Nombre}, con Id {Id}, juega de {Puesto}, gana {Sueldo} y pertenece a la empresa numero {EmpresaID}");
		}
	}



}

