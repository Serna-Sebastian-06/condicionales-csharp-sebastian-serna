string playerOne = ("tijera");
string playerTwo = ("piedra");

string resultado = (playerOne, playerTwo) switch
{
    ("piedra", "tijera") or ("papel", "piedra") or ("tijera", "papel")=> "Gana Player One.",
    ("tijera", "piedra") or ("piedra", "papel") or ("papel", "tijera")=> "Gana Player Two.",
    _ => "Empate"
};

Console.WriteLine(resultado);