using System.Globalization;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, media;

            Console.Write("Número 1: ");
            num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Número 2: ");
            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Número 3: ");
            num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Número 4: ");
            num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"A média entre {num1}, {num2}, {num3} e {num4} é {media:F2}");
        }
    }
}
