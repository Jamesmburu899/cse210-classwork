class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        User user = new User(name);
        GoalManager manager = new GoalManager(user);

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. View Goals");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.RecordGoalProgress();
                    break;
                case "3":
                    user.DisplayGoals();
                    break;
                case "4":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Eternal Quest Program!");
    }
}
