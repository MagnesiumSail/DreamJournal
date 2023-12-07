using System;

namespace DreamJournal
{
    public class DreamEntry
    {
        // Properties
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Mood { get; set; } // Optional: Mood associated with the dream

        // Constructor
        public DreamEntry(DateTime date, string description, string mood = "")
        {
            Date = date;
            Description = description;
            Mood = mood;
        }

        // Method to display the dream entry
        public void Display()
        {
            Console.WriteLine("Date: " + Date.ToShortDateString());
            Console.WriteLine("Mood: " + Mood);
            Console.WriteLine("Description:\n" + Description);
        }
    }
}
