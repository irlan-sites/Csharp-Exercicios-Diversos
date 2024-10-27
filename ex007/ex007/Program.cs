namespace ex007
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

            Console.WriteLine();
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
            Console.WriteLine($"{num1} x {num2} = {num1*num2}");
            Console.WriteLine($"{num1} / {num2} = {num1/num2}");
            Console.WriteLine($"{num1} % {num2} = {num1%num2}");
        }
    }
}
