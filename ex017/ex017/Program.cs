namespace ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, divisores, count;
            n = int.Parse(Console.ReadLine());

            divisores = 1;
            count = n / 2;

            while (count > 0)
            {
                if (n % count == 0)
                {
                    divisores++;
                }
                count--;
            }
            if (divisores == 2)
            {
                Console.WriteLine($"{n} é primo!");
            }
            else
            {
                Console.WriteLine($"{n} não é primo!");
            }
        }
    }
}
