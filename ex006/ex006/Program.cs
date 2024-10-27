namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} x {num2} x {num3} = {num1 * num2 * num3}");
        }
    }
}
