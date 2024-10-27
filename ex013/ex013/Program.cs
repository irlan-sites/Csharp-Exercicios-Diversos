namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 == 30 || num2 == 30 || num1 + num2 == 30);
        }
    }
}
