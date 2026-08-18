Console.WriteLine("Digite o valor do seu saque em reais: ");

if (!int.TryParse(Console.ReadLine(), out int valor) || valor <= 0)
{
    Console.WriteLine("Valor inválido!");
    return;
}

if (valor == 1 || valor == 3)
{
    Console.WriteLine("Não é possível realizar o saque para este valor.");
    return;
}

int restante = valor;

int notas100 = 0;
int notas50 = 0;
int notas20 = 0;
int notas10 = 0;
int notas5 = 0;
int notas2 = 0;

if (restante % 2 != 0)
{
    notas5 = 1;
    restante -= 5;
}

notas100 = restante / 100;
restante %= 100;

notas50 = restante / 50;
restante %= 50;

notas20 = restante / 20;
restante %= 20;

notas10 = restante / 10;
restante %= 10;

notas2 = restante / 2;

Console.WriteLine($"Saque de R$ {valor}:");
Console.WriteLine($"Notas de R$100: {notas100}");
Console.WriteLine($"Notas de R$50: {notas50}");
Console.WriteLine($"Notas de R$20: {notas20}");
Console.WriteLine($"Notas de R$10: {notas10}");
Console.WriteLine($"Notas de R$5: {notas5}");
Console.WriteLine($"Notas de R$2: {notas2}");