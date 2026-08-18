Console.WriteLine("Vamos calcular a área e o perímetro de um retângulo!");

Console.WriteLine("Digite a base do retângulo: ");
double baseRetangulo = double.Parse(Console.ReadLine());
            
Console.WriteLine("Digite a altura do retângulo: ");
double alturaRetangulo = double.Parse(Console.ReadLine());

double area = baseRetangulo * alturaRetangulo;
double perimetro = 2 * (baseRetangulo + alturaRetangulo);

Console.WriteLine($"A área do retângulo é: {area}");
Console.WriteLine($"O perímetro do retângulo é: {perimetro}");