namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número para ver sua tabuada: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
        }
    }
}
