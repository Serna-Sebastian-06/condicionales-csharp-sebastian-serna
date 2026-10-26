Console.Write("¿Tiene empleo? (si/no): ");
string tieneEmpleo = Console.ReadLine().ToLower();

if (tieneEmpleo != "si")
{
    Console.WriteLine("Crédito rechazado");
}
else
{
    Console.Write("Ingrese su ingreso mensual: ");
    double ingreso = double.Parse(Console.ReadLine());

    if (ingreso >= 2500000)
    {
        Console.WriteLine("Crédito alto aprobado");
    }
    else
    {
        Console.WriteLine("Crédito básico aprobado");
    }
}