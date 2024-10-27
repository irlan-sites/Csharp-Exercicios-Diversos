namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite um Número: ");
            n = int.Parse(Console.ReadLine());

            int result = n > 51 ? 3 * (n - 51) : Math.Abs(n - 51);
            Console.WriteLine(result);
        }
    }
}
