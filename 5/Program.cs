Console.WriteLine("Calculadora Simples");

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
int subtracao = numero1 - numero2;
int multiplicacao = numero1 * numero2;
int divisao = numero1 / numero2;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");