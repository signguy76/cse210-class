class ListingActivity : Activity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    protected override string GetStartingMessage()
    {
        return $"Welcome to the Listing Activity: \n\nThis activity will help you reflect on the good things \nin your life by having you list as many things as you can \nin a certain area. \n\nThis task will last {duration} seconds.";
    }

    protected override string GetEndingMessage()
    {
        return $"Good job! You have completed the Listing Activity for {duration} seconds.";
    }

    protected override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        Random rnd = new Random();


        var shuffledPrompts = prompts.OrderBy(x => rnd.Next()).ToArray();
        int promptIndex = 0;

        List<string> items = new List<string>();

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            if (promptIndex < shuffledPrompts.Length)
            {
                Console.WriteLine(shuffledPrompts[promptIndex++]);
                Pause(2); // Pause for 2 seconds
            }

            Console.WriteLine("Start listing items (press Enter after each item, type 'stop' to finish):");

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                string input = Console.ReadLine();
                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase)) break;
                items.Add(input);
            }

            if ((DateTime.Now - startTime).TotalSeconds >= duration) break;
        }

        Console.WriteLine($"You listed {items.Count} items:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}