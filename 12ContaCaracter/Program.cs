string nome = "";

Console.WriteLine("Insira um nome: ");
nome = Console.ReadLine();

int soma = 0;
char[] letras = nome.ToCharArray();
foreach(char c in nome)
{
    soma++;
}
Console.WriteLine($"A soma dos caracteres do nome {nome} é: {soma}");
