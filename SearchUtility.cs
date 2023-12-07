using System;
using System.Collections.Generic;
using System.Linq;

namespace DreamJournal
{
    public static class SearchUtility
    {
        // Search for dream entries by keyword
        public static void SearchEntriesByKeyword(List<DreamEntry> entries, string keyword)
        {
            var foundEntries = entries.Where(e => e.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundEntries.Count == 0)
            {
                Console.WriteLine("No entries found containing the keyword: " + keyword);
                return;
            }

            foreach (var entry in foundEntries)
            {
                entry.Display();
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
