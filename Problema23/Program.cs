Console.Write("Ingrese el usuario (aprendiz): ");
string usuario = Console.ReadLine();

if (usuario != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else
{
    Console.Write("Ingrese la contraseña (Sena2026): ");
    string password = Console.ReadLine();

    if (password == "Sena2026")
    {
        Console.WriteLine("Bienvenido");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}