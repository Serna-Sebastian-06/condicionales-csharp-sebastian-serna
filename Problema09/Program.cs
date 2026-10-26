Console.Write("Ingrese un año: ");
int anio = int.Parse(Console.ReadLine());

if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
{
    Console.WriteLine($"{anio} → Bisiesto");
}
else
{
    Console.WriteLine($"{anio} → No bisiesto");
}