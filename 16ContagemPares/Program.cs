int quantidadePares = 0;

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        quantidadePares++;
    }
}

Console.WriteLine($"Quantidade de números pares: {quantidadePares}");