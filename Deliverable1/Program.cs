using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = "";
            string destination = "";
            string travelSuggestion = "";
            int groupSize;
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?  ");
            vacationType = Console.ReadLine();
            Console.WriteLine("How many people are in your group? ");
            groupSize = Convert.ToInt16(Console.ReadLine());
            if(vacationType == "Adventurous" | vacationType == "adventurous")
            {
                destination = "and go Whitewater Rafting the Grand Canyon";
            }
            if (vacationType == "Tropical" | vacationType == "tropical")
            {
                destination = "and take a beach vacation in Mexico";
            }
            if (vacationType == "Musical" | vacationType == "musical")
            {
                destination = "and go to New Orleans";
            }
            if (groupSize >= 1 && groupSize <= 2)
            {
                travelSuggestion = "  take a First Class flight";
            }
            if (groupSize >= 3 && groupSize <= 5)
            {
                travelSuggestion = " take a Helicopter";
            }
            if (groupSize >= 6)
            {
                travelSuggestion = " travel first class";
            }
            Console.WriteLine("Since you're a group of " + groupSize + " and going on a " + vacationType + " vacation, you should " + travelSuggestion + " to " + destination);
            
        }
    }
}
