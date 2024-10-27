namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Número 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} / {num2} = {num1/num2}");
        }
    }
}
