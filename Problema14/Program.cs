Console.Write("Ingrese la nota final (0 a 5): ");
double nota = double.Parse(Console.ReadLine());

string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Nota: {nota} - {estado}");