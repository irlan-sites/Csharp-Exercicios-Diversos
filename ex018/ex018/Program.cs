using System.Diagnostics;

namespace ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int conversao;
            double temp, result;
            while (true)
            {
                Console.WriteLine("Temperatura (ex: 23): ");
                temp = double.Parse(Console.ReadLine());

                Console.WriteLine("\nQual conversão voce deseja fazer?");
                Console.WriteLine("[1] CELSIUS -> FAHRENHEIT");
                Console.WriteLine("[2] CELSIUS -> KELVIN");
                Console.WriteLine("[3] FAHRENHEIT -> CELSIUS");
                Console.WriteLine("[4] FAHRENHEIT -> KELVIN");
                Console.WriteLine("[5] KELVIN -> CELSIUS");
                Console.WriteLine("[6] KELVIN -> FAHRENHEIT");
                Console.WriteLine("[7] SAIR DO PROGRAMA");

                conversao = int.Parse(Console.ReadLine());

                switch (conversao)
                {
                    case 1:
                        result = (temp * 9 / 5) + 32;
                        Console.WriteLine($"{temp} ºC -> {result:F2} ºF");
                        break;
                    case 2:
                        result = temp + 273.15;
                        Console.WriteLine($"{temp} ºC -> {result:F2} K");
                        break;
                    case 3:
                        result = (temp - 32) * 5 / 9;
                        Console.WriteLine($"{temp} ºF -> {result:F2} ºC");
                        break;
                    case 4:
                        result = (temp - 32) * 5 / 9 + 273.15;
                        Console.WriteLine($"{temp} ºF -> {result:F2} K");
                        break;
                    case 5:
                        result = temp - 273.15;
                        Console.WriteLine($"{temp} K -> {result:F2} ºC");
                        break;
                    case 6:
                        result = (temp - 273.15) * 9 / 5 + 32;
                        Console.WriteLine($"{temp} K -> {result:F2} ºF");
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
                if (conversao == 7)
                {
                    break;
                }
            }
        }
    }
}
