using System;

public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
    }

    public void CommonStart()
    {
        Console.WriteLine($"{Name} Activity");
        Console.WriteLine(Description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        System.Threading.Thread.Sleep(3000);
    }

    public void CommonEnd()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"Completed {Name} Activity in {Duration} seconds.");
        System.Threading.Thread.Sleep(3000);
    }
}
