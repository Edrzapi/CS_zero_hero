namespace CS_Zero_Hero
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
