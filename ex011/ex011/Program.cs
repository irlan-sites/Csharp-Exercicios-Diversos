namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Número 1: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine(3 * (a + b));
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }
    }
}
