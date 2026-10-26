Console.Write("Ingrese la categoría del vehículo (M, A, B, C): ");
char categoria = char.ToUpper(char.Parse(Console.ReadLine()));

(string nombre, int tarifa) = categoria switch
{
    'M' => ("moto", 0),
    'A' => ("automóvil", 12000),
    'B' => ("bus", 25000),
    'C' => ("camión", 38000),
    _ => throw new Exception("Categoría desconocida")
};

Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifa:N0}");