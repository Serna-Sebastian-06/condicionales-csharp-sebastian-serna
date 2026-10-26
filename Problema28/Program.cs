Console.Write("Ingrese el valor de la compra: ");
double compra = double.Parse(Console.ReadLine());

Console.Write("¿Es cliente frecuente? (si/no): ");
bool frecuente = Console.ReadLine().ToLower() == "si";

double descuentoBase = 0;

if (compra >= 500000)
{
    descuentoBase = 0.15;
}
else if (compra >= 200000)
{
    descuentoBase = 0.10;
}
else if (compra >= 100000)
{
    descuentoBase = 0.05;
}

double descuentoAdicional = (frecuente && compra >= 100000) ? 0.05 : 0;
double descuentoTotal = descuentoBase + descuentoAdicional;
double totalPagar = compra * (1 - descuentoTotal);

Console.WriteLine($"Compra: ${compra:N0} | Descuento total: {descuentoTotal * 100}% | Total a pagar: ${totalPagar:N0}");