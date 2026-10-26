Console.Write("Ingrese el día de la semana (ej. lunes, martes): ");
string dia = Console.ReadLine().ToLower();

Console.Write("¿Es estudiante? (si/no): ");
bool esEstudiante = Console.ReadLine().ToLower() == "si";

int precio = 0;

if (dia == "martes")
{
    precio = 7000;
}
else if (dia == "sábado" || dia == "domingo")
{
    precio = 15000;
}
else
{
    precio = esEstudiante ? 9000 : 12000;
}

Console.WriteLine($"Precio de la boleta: ${precio:N0}");