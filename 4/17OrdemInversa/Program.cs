double[] numeros = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    numeros[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Números na ordem inversa:");
for (int i = numeros.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}