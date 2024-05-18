class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    protected override string GetStartingMessage()
    {
        return $"Welcome to the Breathing Activity:\n\nThis activity will help you relax by walking you through \nbreathing in and out slowly. Clear your mind and focus on \nyour breathing. \n\nYour activity will last {duration} seconds.";
    }

    protected override string GetEndingMessage()
    {
        return $"Good job! \n\nYou have completed the Breathing Activity for {duration} seconds.";
    }

    protected override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(4); // Pause for 4 seconds

            if ((DateTime.Now - startTime).TotalSeconds >= duration) break;

            Console.WriteLine("Breathe out...");
            Pause(5); // Pause for 5 seconds
        }
    }
}
