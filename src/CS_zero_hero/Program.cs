namespace CS_zero_hero
{
    class Program
    {
        static void methodToHold(string[] args)
        {
            InternalHelper ih = new InternalHelper();
            ih.PrintHelp();  // Works fine in the same project

            PublicHelper ph = new PublicHelper();
            ph.PrintHelp();  // Also works

            Console.WriteLine("Access modifiers demonstration complete.");
        }
    }
}
