Console.Write("Ingrese la estatura en metros (ej. 1.45): ");
double estatura = double.Parse(Console.ReadLine());

Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("¿Va acompañado por un adulto? (si/no): ");
bool acompañado = Console.ReadLine().ToLower() == "s";

if (estatura >= 1.40 && (edad >= 12 || acompañado))
{
    Console.WriteLine("Puede subir");
}
else
{
    Console.WriteLine("No puede subir");
}