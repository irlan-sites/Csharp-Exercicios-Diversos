namespace ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora de Fatorial
            int n, count;
            long result;
            n = int.Parse(Console.ReadLine());
            count = 0;
            result = 1;

            while ((n - count) > 0)
            {
                result *= n - count;
                count++;
            }
            Console.WriteLine($"{n}! = {result}");
        }
    }
}
