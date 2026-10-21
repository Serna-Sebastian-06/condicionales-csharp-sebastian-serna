int menuCajeroAutomatico = 1;

string opcionCajero = menuCajeroAutomatico switch
{
    1 => $"Usted ha seleccionado la opción: Consultar saldo",
    2 => "Usted ha seleccionado la opción: Retirar",
    3 => "Usted ha seleccionado la opción: Depositar",
    4 => "Usted ha seleccionado la opción: Salir.",
    _ => "Opción no válida"
};

Console.WriteLine(opcionCajero);
