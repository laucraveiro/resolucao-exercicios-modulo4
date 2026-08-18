Console.WriteLine("Vamos calcular a média de 8 notas!");

double nota1;
while (true)
{
    Console.WriteLine("Digite a primeira nota: ");
    var valorDigitado1 = Console.ReadLine();

    if (double.TryParse(valorDigitado1, out nota1))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota2;
while (true)
{
    Console.WriteLine("Digite a segunda nota: ");
    var valorDigitado2 = Console.ReadLine();

    if (double.TryParse(valorDigitado2, out nota2))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota3;
while (true)
{
    Console.WriteLine("Digite a terceira nota: ");
    var valorDigitado3 = Console.ReadLine();

    if (double.TryParse(valorDigitado3, out nota3))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota4;
while (true)
{
    Console.WriteLine("Digite a quarta nota: ");
    var valorDigitado4 = Console.ReadLine();

    if (double.TryParse(valorDigitado4, out nota4))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota5;
while (true)
{
    Console.WriteLine("Digite a quinta nota: ");
    var valorDigitado5 = Console.ReadLine();

    if (double.TryParse(valorDigitado5, out nota5))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota6;
while (true)
{
    Console.WriteLine("Digite a sexta nota: ");
    var valorDigitado6 = Console.ReadLine();

    if (double.TryParse(valorDigitado6, out nota6))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota7;
while (true)
{
    Console.WriteLine("Digite a sétima nota: ");
    var valorDigitado7 = Console.ReadLine();

    if (double.TryParse(valorDigitado7, out nota7))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double nota8;
while (true)
{
    Console.WriteLine("Digite a oitava e última nota: ");
    var valorDigitado8 = Console.ReadLine();

    if (double.TryParse(valorDigitado8, out nota8))
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número decimal válido.");
    }
}

double media = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6 + nota7 + nota8) / 8;

Console.WriteLine($"A média é: {media}");