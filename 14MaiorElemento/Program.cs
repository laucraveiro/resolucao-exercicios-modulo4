int[] numeros = new int[10];

for(int i=0; i<10; i++)
{
    Console.Write("Insira um número:");
    numeros[i] = int.Parse(Console.ReadLine()); 
}

int maior = numeros[0];
int posicao = 0;

for (int i=1; i<10; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
        posicao = i;
    }
}

Console.WriteLine($"Maior valor: {maior}");
Console.WriteLine($"Posição em que ele aparece: {posicao + 1}");