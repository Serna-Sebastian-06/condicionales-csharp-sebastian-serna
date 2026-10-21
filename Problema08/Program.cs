string texto = "0   ";

if (texto == "a" || texto == "e" || texto == "i" || texto == "o" || texto == "u")
{
    Console.WriteLine($"Usted ha ingresado la letra: {texto}, es una vocal.");
}
else if(texto == "q" || texto == "w" || texto == "r" || texto == "t" || texto == "y" || texto == "p" || texto == "s" || texto == "d" || texto == "f" || texto == "g" || texto == "h" || texto == "j" || texto == "k" || texto == "l" || texto == "ñ" || texto == "z" || texto == "x" || texto == "c" || texto == "v" || texto == "b" || texto == "n" || texto == "m")
{
    Console.WriteLine($"Usted ha ingresado la letra: {texto}, es una consonante.");
}
else
{
    Console.WriteLine($"{texto} no es una letra, crack.");
}