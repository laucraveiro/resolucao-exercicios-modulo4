int numero = 1;
int soma = 0;

while (numero != 0)
{
    Console.Write("Insira um número inteiro: ");
    numero = int.Parse(Console.ReadLine());
    
    if (numero != 0)
    {
        soma += numero;
    }
}

Console.WriteLine($"Soma dos valores digitados: {soma}"); 
