namespace Ejercicio2
{
    internal class ControlEmpresasEmpleados
	{

		public List<Club> listaClubes;
		public List<Empleado> listaEmpleados;

		public ControlEmpresasEmpleados()
		{
            listaClubes = new List<Club>();
            listaEmpleados = new List<Empleado>();

            listaClubes.Add(new Club { Id = 1, Nombre = "Nacional" });
            listaClubes.Add(new Club { Id = 2, Nombre = "Barcelona" });
            listaClubes.Add(new Club { Id = 3, Nombre = "Manchester City" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergio", Puesto = "Arquero", EmpresaID = 1, Sueldo = 100 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Sebastian", Puesto = "Delantero", EmpresaID = 1, Sueldo = 35000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Luis", Puesto = "Delantero", EmpresaID = 1, Sueldo = 3600 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Felipe", Puesto = "Medio", EmpresaID = 1, Sueldo = 4500 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "Diego", Puesto = "Defensa", EmpresaID = 1, Sueldo = 1200 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Lionel", Puesto = "Delantero", EmpresaID = 2, Sueldo = 47800 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergio", Puesto = "Delantero", EmpresaID = 3, Sueldo = 2500 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Ngolo", Puesto = "Medio", EmpresaID = 3, Sueldo = 1700 });

        }

        public void getSeo(string _Puesto)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Puesto == _Puesto
                                              select empleado;
            foreach (Empleado item in empleados)
            {
                item.getDatosEmpleado();
            }
        }

        public void getJugadoresOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Nombre
                                              select empleado;
            foreach (Empleado item in empleados)
            {
                item.getDatosEmpleado();
            }
        }

        public void getJugadoresPorSueldo()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Sueldo
                                              select empleado;
            foreach (Empleado item in empleados)
            {
                item.getDatosEmpleado();
            }
        }

        public void getEmpleadoPorClub(int _Club)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join club in listaClubes on empleado.EmpresaID
                                              equals club.Id
                                              where club.Id == _Club
                                              select empleado;

            foreach (Empleado item in empleados)
            {
                item.getDatosEmpleado();
            }

        }

        public void promedioSueldo()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaID into g
                           select new { empresa = g.Key, PromedioSueldo = g.Average(e => e.Sueldo) };

            foreach (var item in consulta)
            {
                switch (item.empresa)
                {
                    case 1:
                        Console.WriteLine($"El club Nacional de Futbol - Promedio de sueldo: {item.PromedioSueldo}");
                        break;
                    case 2:
                        Console.WriteLine($"El club FC Barcelona - Promedio de sueldo: {item.PromedioSueldo}");
                        break;
                    case 3:
                        Console.WriteLine($"El club Manchester City - Promedio de sueldo: {item.PromedioSueldo}");
                        break;
                }
            }


        }

    }



}

