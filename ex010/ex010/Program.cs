namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.Write("Número 1: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            z = int.Parse(Console.ReadLine());

            int a = (x + y) * z;
            int b = x * y + y * z;

            Console.WriteLine($"({x} + {y}) x {z} = {a} \n{x} x {y} + {y} x {z} = {b}");
        }
    }
}
