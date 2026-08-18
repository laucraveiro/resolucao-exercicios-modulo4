Console.WriteLine("Vamos somar dois números!");

int numero1;
while (true)
{
    Console.WriteLine("Digite o primeiro número: ");
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

int numero2;
while (true)
{
    Console.WriteLine("Digite o segundo número: ");
    var valorDigitado2 = Console.ReadLine();

    if (int.TryParse(valorDigitado2, out numero2))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número inteiro válido.");
    }
}

int soma = numero1 + numero2;

Console.WriteLine($"A soma de {numero1} + {numero2} é: {soma}");