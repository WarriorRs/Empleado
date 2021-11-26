using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[]args) {

            int FechaDeIngresoTemporal = 0, FechaDeSalidaTemporal = 0, HorasTrabajadas = 0, FechaDeIngresoFija = 0, ComplementoAnualFijo = 50, FechaActual2 = 0;
            double PrecioPorHora = 4.5, Sueldo = 700, SueldoEmpleadoPorHora = 0, SueldoFijo = 0;
            string FechaActual1 = DateTime.Now.Year.ToString();

            Empleado empleado = new Empleado();
            EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora();
            EmpleadoFijo empleadoFijo = new EmpleadoFijo();
            EmpleadoTemporal empleadoTemporal = new EmpleadoTemporal();
            

            empleadoTemporal.Nombres = "Darwin Natanael";
            empleadoTemporal.Apellidos = "Bravo Coppiano";
            empleadoTemporal.Edad = 27;
            empleadoTemporal.Departamento = "Marketing";

            Console.Write("Ingrese la fecha de ingreso de " + empleadoTemporal.Nombres + " " + empleadoTemporal.Apellidos + ": ");
            FechaDeIngresoTemporal = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha de salida de " + empleadoTemporal.Nombres + " " + empleadoTemporal.Apellidos + ": ");
            FechaDeSalidaTemporal = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl sueldo mensual de " + empleadoTemporal.Nombres + " " + empleadoTemporal.Apellidos + " es de: $" + Sueldo);



            empleadoPorHora.Nombres = "Gabriel Natanael";
            empleadoPorHora.Apellidos = "Alonso Saldarriaga";
            empleadoPorHora.Edad = 30;
            empleadoPorHora.Departamento = "Marketing";

            Console.Write(" \n \nIngrese las horas trabajadas de " + empleadoPorHora.Nombres + " " + empleadoPorHora.Apellidos + ": ");
            HorasTrabajadas = int.Parse(Console.ReadLine());

            SueldoEmpleadoPorHora = HorasTrabajadas * PrecioPorHora;

            Console.Write("\nEl sueldo de " + empleadoPorHora.Nombres + " " + empleadoPorHora.Apellidos + " es de: $" + SueldoEmpleadoPorHora);
            


            empleadoFijo.Nombres = "Fabricio Sair";
            empleadoFijo.Apellidos = "Alonso Andrade";
            empleadoFijo.Edad = 30;
            empleadoFijo.Departamento = "Recursos Humanos";

            FechaActual2 = Convert.ToInt32(FechaActual1);
            
            Console.Write("\n\n\nIngrese la fecha de ingreso de " + empleadoFijo.Nombres + " " + empleadoFijo.Apellidos + ": ");
            FechaDeIngresoFija = int.Parse(Console.ReadLine());

            SueldoFijo = ((((FechaActual2 - FechaDeIngresoFija) * ComplementoAnualFijo) + Sueldo * 12) / 12);

            Console.Write("\nEl sueldo mensual de " + empleadoFijo.Nombres + " " + empleadoFijo.Apellidos + " es de: $" + SueldoFijo);
        }
    }
}