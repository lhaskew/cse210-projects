using System;

public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void Run()
    {
        CommonStart();
        Console.WriteLine("Starting listing activity...");
        string[] listingPrompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        System.Threading.Thread.Sleep(3000);

        int count = 0;
        int countdown = Duration;
        while (countdown > 0)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
            countdown--;
        }
        Console.WriteLine($"You listed {count} items.");
        CommonEnd();
    }
}
