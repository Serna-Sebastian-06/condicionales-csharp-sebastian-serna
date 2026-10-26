Console.Write("Ingrese la nota 1 (0 a 100): ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la nota 2 (0 a 100): ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Ingrese la nota 3 (0 a 100): ");
double n3 = double.Parse(Console.ReadLine());

double promedio = (n1 + n2 + n3) / 3.0;

char letra = promedio switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string retroalimentacion = letra switch
{
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    'F' => "Debe presentar plan de mejoramiento",
    _ => ""
};

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Promedio: {promedio:F1} | Letra: {letra} | {retroalimentacion} | {estado}");

if (promedio == 100)
{
    Console.WriteLine("¡Mención de honor!");
}