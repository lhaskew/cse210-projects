using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing") { }

    public void Run()
    {
        CommonStart();
        Console.WriteLine("Starting breathing activity...");
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(2000);
        }
        CommonEnd();
    }
}
