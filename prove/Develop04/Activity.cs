abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.WriteLine(GetStartingMessage());
        Pause(3); // Pause for 3 seconds
        PerformActivity();
        Console.WriteLine(GetEndingMessage());
        Pause(3); // Pause for 3 seconds
    }

    protected abstract string GetStartingMessage();

    protected abstract string GetEndingMessage();

    protected abstract void PerformActivity();

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine();
    }
}
