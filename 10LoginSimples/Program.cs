string senhaCorreta = "123";
string senha = "";
do
{
    Console.Clear();
    Console.Write("Usuário: ");
    string usuario = Console.ReadLine();
    Console.Write("Senha: ");
    senha = Console.ReadLine();
} while (senha != senhaCorreta);