Console.Write("Ingrese el primer número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el operador (+, -, *, /): ");
char operador = char.Parse(Console.ReadLine());

double resultado = operador switch
{
    '+' => num1 + num2,
    '-' => num1 - num2,
    '*' => num1 * num2,
    '/' => num2 == 0 ? throw new DivideByZeroException("No se puede dividir entre cero") : (double)num1 / num2,
    _ => throw new InvalidOperationException("Operador no soportado")
};

Console.WriteLine($"Resultado: {resultado}");