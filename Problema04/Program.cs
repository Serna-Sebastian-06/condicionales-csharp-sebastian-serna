byte nivelBateria = 15;

string alerta = nivelBateria < 15 ? $"Batería baja: conecte el cargador. Nivel actual: {nivelBateria}%" : $"Nivel actual: {nivelBateria}";
Console.WriteLine(alerta);