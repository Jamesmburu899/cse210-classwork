using System;

// Job class represents a single job entry
public class Job
{
    // Properties with private setters for encapsulation
    public string JobTitle { get; private set; }
    public string Company { get; private set; }
    public int StartYear { get; private set; }
    public int EndYear { get; private set; }

    // Constructor to initialize job details
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        if (string.IsNullOrEmpty(jobTitle) || string.IsNullOrEmpty(company))
        {
            throw new ArgumentException("Job title and company cannot be null or empty.");
        }
        if (startYear > endYear)
        {
            throw new ArgumentException("Start year cannot be greater than end year.");
        }

        JobTitle = jobTitle;
        Company = company;
        StartYear = startYear;
        EndYear = endYear;
    }

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}