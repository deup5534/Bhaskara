Console.Clear();

enfeitinho("Esse programa é tipo uma calculadora de Bhaskara.\n");
Console.ForegroundColor = ConsoleColor.Yellow;
enfeitinho("Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
enfeitinho("\nPressione uma tecla para avançar...\n");
Console.ReadKey();
Console.ResetColor();

double a, b, c, delta, x1, x2;

Console.ForegroundColor = ConsoleColor.White;
enfeitinho("\ndigite o primeiro algarismo (a):");
a = Convert.ToDouble(Console.ReadLine());

enfeitinho("\ndigite o segundo algarismo (b):");
b = Convert.ToDouble(Console.ReadLine());

enfeitinho("\ndigite o terceiro algarismo (c):");
c = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();

if (a == 0)
{

    Console.ForegroundColor = ConsoleColor.Red;
    enfeitinho("\nisso não é uma equação de segundo grau!\n");
    Console.ResetColor();

}    

delta = b * b - 4 * a * c;

if (delta <= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        enfeitinho($"\nComo delta é = {delta:N2}, a equação não possui raízes reais.\n");
        Console.ResetColor();
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.ForegroundColor = ConsoleColor.Magenta;
        enfeitinho($"x1 = {x1:N2} e x2 = {x2:N2}\n");
        Console.ResetColor();
    }
    
void enfeitinho(string mensagem)

    {

        int frase = mensagem.Length;

for (int i = 0; i < frase; i++)

{

Console.Write(mensagem[i]);

Thread.Sleep(55);

}

    }
