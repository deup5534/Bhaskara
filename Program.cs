Console.Write("---bhaskara---");
double a, b, c, delta, x1, x2;

Console.Write("\ndigite o primeiro algarismo (a):");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("\ndigite o segundo algarismo (b):");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("\ndigite o terceiro algarismo (c):");
c = Convert.ToDouble(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("isso não é uma equação de segundo grau...");
}
else
    {}
    delta = b * b - 4 * a * c;
    
    if (delta < 0)
    {
        Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");
    }
    