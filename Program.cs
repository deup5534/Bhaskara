Console.Clear();

Console.WriteLine("Esse programa é tipo uma calculadora de Bhaskara.");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("\nPressione uma tecla para avançar...");
Console.ReadKey();
Console.ResetColor();

double a, b, c, delta, x1, x2;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("\ndigite o primeiro algarismo (a):");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("\ndigite o segundo algarismo (b):");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("\ndigite o terceiro algarismo (c):");
c = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nisso não é uma equação de segundo grau!\n");
    Console.ResetColor();
}    
    delta = b * b - 4 * a * c;
    
   if (delta < 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nComo delta é = {delta:N2}, a equação não possui raízes reais.");
        Console.ResetColor();
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");
        Console.ResetColor();
    }
    