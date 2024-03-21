using Designpatterns;
string archivoEmpleados = "empleados.txt";

IEmpleadoRepository empleadosRepository = new EmpleadoRepositoryArchivo(archivoEmpleados);

GestorEmpleado gestorEmpleado = new GestorEmpleado(empleadosRepository);

gestorEmpleado.AgregarEmpleado(new Empleado { Nombre = "Ena King Sing", Edad = 38, Cargo = "Administradora" });
gestorEmpleado.AgregarEmpleado(new Empleado { Nombre = "Kamila Garcia", Edad = 20, Cargo = "Secretaeria" });


Console.WriteLine("Todos los Empleados: ");
foreach (var empleado in gestorEmpleado.ObtenerTodosLosEmpleados())
    Console.WriteLine($"Nombre: {empleado.Nombre}, " + $"Edad: {empleado.Edad}, " + $"Cargo: {empleado.Cargo}");