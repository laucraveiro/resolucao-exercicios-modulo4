Random random = new Random();

int numeroSorteado = random.Next(1, 101);
int palpite;
int tentativas = 0;

Console.WriteLine("Jogo da Senha");
Console.WriteLine("Tente adivinhar o número sorteado entre 1 e 100.");

do
{
    Console.WriteLine("Digite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());
    tentativas++;

    if (palpite < numeroSorteado)
    {
        Console.WriteLine("O número sorteado é maior! Tente novamente.");
    }
    else if (palpite > numeroSorteado)
    {
        Console.WriteLine("O número sorteado é menor! Tente novamente.");
    }
    else
    {
        Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativa(s)!");
    }

} while (palpite != numeroSorteado);