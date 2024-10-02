using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a scripture instance
            var scripture = new Scripture(new Reference("John 3:16"), 
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

            // Start memorization process
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.DisplayScripture()); // Call the DisplayScripture method
                Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit.");

                var input = Console.ReadLine();
                if (input?.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords();
            }
        }
    }
}
