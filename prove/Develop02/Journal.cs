using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; private set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
            return;
        }

        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found. Please check the filename and try again.");
                return;
            }

            Entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new Entry(parts[0], parts[1], parts[2]);
                        Entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }
}