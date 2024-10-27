namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(100 - num) <= 10 || Math.Abs(200 - num) <= 10);
        }
    }
}
