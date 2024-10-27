namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = Console.ReadLine();
            Console.WriteLine(original.ToUpper().Substring(0, 2) == "IF" ? original : "if " + original);
        }
    }
}
