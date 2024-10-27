namespace ex019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usuário digita um número n.
            int limite, count, soma;
            Console.WriteLine("Digite um número: ");
            limite = int.Parse(Console.ReadLine());
            count = 0;
            soma = 0;

            // programa calcula a soma dos n primeiros números pares.
            while (count <= (limite*2))
            {
                if (count % 2  == 0)
                {
                    soma += count;
                }
                count++;
            }
            Console.WriteLine($"SOMA: {soma}");
        }
    }
}
