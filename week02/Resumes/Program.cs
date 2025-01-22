using System;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Create a resume instance
        Resume myResume = new Resume("james mburu");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.Display();

        // Save the resume to a file
        myResume.SaveToFile("resume.txt");

        // Load the resume from a file
        Resume loadedResume = Resume.LoadFromFile("resume.txt");
        if (loadedResume != null)
        {
            loadedResume.Display();
        }
    }
}