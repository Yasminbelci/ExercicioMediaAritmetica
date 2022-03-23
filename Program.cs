double nr1, nr2, nr3, media;
const double constanteDivisor = 3;

Console.WriteLine("Calculador de média aritmética\n");

Console.Write("Insira o primeiro número: ");
nr1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira o segundo número: ");
nr2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira o terceiro número: ");
nr3 = Convert.ToDouble(Console.ReadLine()!);

media = (nr1 + nr2 + nr3) / constanteDivisor;

Console.WriteLine($"A média é {media}");