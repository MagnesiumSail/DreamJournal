using System;

namespace DreamJournal
{
    public class JournalManager
    {
        private DreamJournal journal;

        public JournalManager()
        {
            journal = new DreamJournal();
        }

        public void AddEntry()
        {
            Console.WriteLine("Enter the date of your dream (yyyy-mm-dd):");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format:");
            }

            Console.WriteLine("Enter your dream description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter the mood of the dream (optional):");
            string mood = Console.ReadLine();

            DreamEntry entry = new DreamEntry(date, description, mood);
            journal.AddEntry(entry);
        }

        public void RemoveEntry()
        {
            Console.WriteLine("Enter the date of the dream entry to remove (yyyy-mm-dd):");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format:");
            }

            journal.RemoveEntry(date);
        }

        public void ListEntries()
        {
            journal.ListEntries();
        }

        public void SearchEntries()
        {
            Console.WriteLine("Enter the keyword to search:");
            string keyword = Console.ReadLine();
            SearchUtility.SearchEntriesByKeyword(journal.GetEntries(), keyword);
        }
    }
}
