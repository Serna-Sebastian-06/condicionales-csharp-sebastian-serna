object dato = true;

switch (dato)
{
    case string texto:
        Console.WriteLine($"Texto de {texto.Length} caracteres");
        break;
    case int entero:
        Console.WriteLine($"Entero: {entero}");
        break;
    case double valorDecimal:
        Console.WriteLine($"Decimal: {valorDecimal}");
        break;
    case bool booleano:
        Console.WriteLine($"Booleano: {booleano}");
        break;
    default:
        Console.WriteLine("Tipo no reconocido");
        break;
}