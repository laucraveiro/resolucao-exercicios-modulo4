Console.WriteLine("Digite o valor em reais: ");
double reais = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da cotação em dolár: ");
double cotacaoDolar = double.Parse(Console.ReadLine());

double dolar = reais / cotacaoDolar;

Console.WriteLine($"R$ {reais:F2} valem $ {dolar:F2}");