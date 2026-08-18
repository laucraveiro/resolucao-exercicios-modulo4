string senha = "";
int contador = 0;

do
{
    Console.WriteLine("Insira uma senha: ");
    senha = Console.ReadLine();
    contador = 0;

    foreach (char c in senha)
    {
        contador++;
    }
    if (contador < 8)
    {
        Console.WriteLine($"A senha deve ter pelo menos 8 caracteres");
    }
} while(contador < 8);

Console.WriteLine($"Senha aceita, possui {contador} caracteres");