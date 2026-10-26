Console.Write("Ingrese el peso en kg (ej. 70,5): ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Ingrese la estatura en centimetros (ej. 175): ");
double estatura = double.Parse(Console.ReadLine());

double imc = peso / ((estatura / 100) * (estatura / 100));
string categoria;

if (imc < 18.5)
{
    categoria = "Bajo peso";
}
else if (imc < 25)
{
    categoria = "Peso normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else
{
    categoria = "Obesidad";
}

Console.WriteLine($"IMC: {imc:F1} - {categoria}");