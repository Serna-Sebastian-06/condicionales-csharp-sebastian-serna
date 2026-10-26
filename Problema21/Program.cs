Console.Write("Ingrese la cantidad de artículos en el carrito: ");
int cantidad = int.Parse(Console.ReadLine());

string mensaje = cantidad == 1 ? "artículo" : "artículos";
Console.WriteLine($"Tienes {cantidad} {mensaje} en el carrito");