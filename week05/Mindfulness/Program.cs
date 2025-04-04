using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // show menu options for different mindfulness activities
            Console.WriteLine("\nMindfulness activities:");
            Console.WriteLine("1. Breathing exercise");
            Console.WriteLine("2. Reflection exercise");
            Console.WriteLine("3. Listing exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().PerformActivity(); // start breathing activity
                    break;
                case "2":
                    new ReflectionActivity().PerformActivity(); // start reflection activity
                    break;
                case "3":
                    new ListingActivity().PerformActivity(); // start listing activity
                    break;
                case "4":
                    Console.WriteLine("Goodbye! See you next time!");
                    return;
                default:
                    Console.WriteLine("Oops! Invalid choice, please try again.");
                    break;
            }
        }
    }
}
