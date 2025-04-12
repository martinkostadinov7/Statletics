namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            if (!double.TryParse(input, out double timeSeconds))
                throw new ArgumentException("Invalid time!");

        }
    }
}
