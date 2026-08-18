int numero1;
while (true)
{
    Console.WriteLine("Digite um número inteiro: ");
    var valorDigitado1 = Console.ReadLine();

    if (int.TryParse(valorDigitado1, out numero1))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número inteiro válido.");
    }
}

int antecessor = numero1 - 1;
int sucessor = numero1 + 1;

Console.WriteLine($"Antecessor: {antecessor}");
Console.WriteLine($"Número informado: {numero1}");
Console.WriteLine($"Sucessor: {sucessor}");