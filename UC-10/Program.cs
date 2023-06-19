namespace UC_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to match:");
            string? value = Console.ReadLine();
            if (value != null)
            {
                bool validated = StringValidator.Validate(value, 10);
                Console.WriteLine(validated);
            }
        }
    }
}
