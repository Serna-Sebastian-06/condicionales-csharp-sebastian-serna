decimal pesoPaqueteKilogramos = -1;
string mensajePesoInvalido = "";
decimal precioPaquete;
{
    if (pesoPaqueteKilogramos > 0 && pesoPaqueteKilogramos < 1)
    {
        precioPaquete = 8.000m;
    }
    else if (pesoPaqueteKilogramos >= 1 && pesoPaqueteKilogramos < 5)
    {
        precioPaquete = 15.000m;
    }
    else if (pesoPaqueteKilogramos >= 5 && pesoPaqueteKilogramos < 20)
    {
        precioPaquete = 32.000m;
    }
    else if (pesoPaqueteKilogramos >= 20)
    {
        precioPaquete = 60.000m;
    }
    else
    {
        precioPaquete = 0m;
        mensajePesoInvalido = "peso inválido.";
    }
}
Console.WriteLine($"El paquete pesa {pesoPaqueteKilogramos}KG, su precio es: ${precioPaquete}. {mensajePesoInvalido}");