using System;

namespace DreamJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            JournalManager manager = new JournalManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nDream Journal Application");
                Console.WriteLine("1. Add Dream Entry");
                Console.WriteLine("2. Remove Dream Entry");
                Console.WriteLine("3. List All Dream Entries");
                Console.WriteLine("4. Search Dream Entries");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        manager.AddEntry();
                        break;
                    case "2":
                        manager.RemoveEntry();
                        break;
                    case "3":
                        manager.ListEntries();
                        break;
                    case "4":
                        manager.SearchEntries();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}
