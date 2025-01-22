using System;
using System.Collections.Generic;
using System.IO;

// Resume class represents a person's resume
public class Resume
{
    // Properties with private setters for encapsulation
    public string Name { get; private set; }
    public List<Job> Jobs { get; private set; }

    // Constructor to initialize resume
    public Resume(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty.");
        }

        Name = name;
        Jobs = new List<Job>();
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        Jobs.Add(job);
    }

    // Method to display the resume
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (var job in Jobs)
        {
            job.Display();
        }
    }

    // Method to save the resume to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(Name);
                foreach (var job in Jobs)
                {
                    writer.WriteLine($"{job.JobTitle}|{job.Company}|{job.StartYear}|{job.EndYear}");
                }
            }
            Console.WriteLine("Resume saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving resume: {ex.Message}");
        }
    }

    // Method to load the resume from a file
    public static Resume LoadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length == 0)
            {
                throw new Exception("File is empty.");
            }

            string name = lines[0];
            Resume resume = new Resume(name);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts.Length == 4)
                {
                    Job job = new Job(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                    resume.AddJob(job);
                }
            }

            Console.WriteLine("Resume loaded successfully.");
            return resume;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading resume: {ex.Message}");
            return null;
        }
    }
}