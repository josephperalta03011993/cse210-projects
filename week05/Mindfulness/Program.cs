using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if(choice == "4")
            {
                break;
            }

            if(choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if(choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if(choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else
            {   
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}