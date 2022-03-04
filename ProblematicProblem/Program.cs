using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        Random rng;
static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
{
    Console.Write("We are going to need your information first! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();
    Console.Write("What is your age? ");
    int userAge = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write($"Hello, {userName} welcome to the random activity generator! \nWould you like to generate a random activity?  enter true/false: ");
    Console.WriteLine();

    bool seeList = bool.Parse(Console.ReadLine().ToLower());
    if (seeList == true)
    {
        foreach (string activity in activities)
        {
            Console.Write($"{activity} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
        Console.Write("Would you like to add any activities before we generate one? enter true/false: ");
        bool addToList = bool.Parse(Console.ReadLine().ToLower());
        Console.WriteLine();
        while (addToList == true)
        {
            Console.Write("What would you like to add? ");
            string userAddition = Console.ReadLine();
            activities.Add(userAddition);
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? enter true/false: ");
                    string addMoreToList = Console.ReadLine().ToLower();
                    if (addMoreToList != "yes") break;
                    else continue;
        }
        
    }

            //continue to while loop
            Console.WriteLine("Continue and add to database? enter true/false");
            bool cont = bool.Parse(Console.ReadLine().ToLower());
            while (cont == true)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
                Random rng = new Random();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];
                if (userAge > 21 && randomActivity == "Wine Tasting")
        {
                    Console.WriteLine();
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
        
        }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Do you want to grab another activity? enter true/false: ");
                Console.WriteLine();
        string cont1 = Console.ReadLine().ToLower();
                if (cont1 != "yes") break;
                else continue;
    }
            Console.WriteLine("Thanks, have a good day and enjoy your activity!");
}
    }
}