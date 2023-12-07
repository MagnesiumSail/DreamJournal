using System;
using System.Collections.Generic;
using System.Linq;

namespace DreamJournal
{
    public class DreamJournal
    {
        // List to store dream entries
        private List<DreamEntry> entries;

        // Constructor
        public DreamJournal()
        {
            entries = new List<DreamEntry>();
        }

        // Add a new dream entry
        public void AddEntry(DreamEntry entry)
        {
            entries.Add(entry);
            Console.WriteLine("Dream entry added successfully.");
        }

        // Remove a dream entry
        public void RemoveEntry(DateTime date)
        {
            var entry = entries.FirstOrDefault(e => e.Date.Date == date.Date);
            if (entry != null)
            {
                entries.Remove(entry);
                Console.WriteLine("Dream entry removed.");
            }
            else
            {
                Console.WriteLine("No entry found on the specified date.");
            }
        }

        // List all dream entries
        public void ListEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No dream entries found.");
                return;
            }

            foreach (var entry in entries)
            {
                entry.Display();
                Console.WriteLine("---------------------------------");
            }
        }

        public List<DreamEntry> GetEntries()
        {
            return entries;
        }

    }
}
