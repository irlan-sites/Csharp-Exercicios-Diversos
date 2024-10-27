namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Número 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}
