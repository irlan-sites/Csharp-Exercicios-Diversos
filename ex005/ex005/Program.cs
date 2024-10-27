namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"\nDepois da troca:\n\nNúmero 1: {num1}\nNúmero 2: {num2}");
        }
    }
}
