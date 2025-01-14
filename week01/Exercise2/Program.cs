using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        
        int percent;
        if (!int.TryParse(answer, out percent))
        {
            Console.WriteLine("Please enter a valid number for the grade percentage.");
            return; 
        }

        string letter = "";
        string sign = ""; 
      
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (letter != "A" && letter != "F")
        {
            int lastDigit = percent % 10;
            if (lastDigit >= 7)
            {
                sign = "+"; 
            }
            else if (lastDigit < 3)
            {
                sign = "-"; 
            }
        }
        
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
