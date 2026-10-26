Console.Write("Ingrese el rol (admin, instructor, aprendiz): ");
string rol = Console.ReadLine().ToLower();

Console.Write("Ingrese la hora de llegada (0 a 23): ");
int hora = int.Parse(Console.ReadLine());

bool accesoPermitido = false;

if (rol == "admin")
{
    accesoPermitido = true;
}
else if (rol == "instructor" && hora >= 6 && hora <= 21)
{
    accesoPermitido = true;
}
else if (rol == "aprendiz" && hora >= 6 && hora <= 18)
{
    accesoPermitido = true;
}

if (accesoPermitido)
{
    Console.WriteLine("Acceso permitido");
}
else
{
    Console.WriteLine("Acceso denegado");
}