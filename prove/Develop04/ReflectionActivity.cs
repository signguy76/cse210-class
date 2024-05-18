class ReflectionActivity : Activity
{
    private static readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    protected override string GetStartingMessage()
    {
        return $"\nWelcome to the Reflection Activity: \n\nThis activity will help you reflect on times in your life \nwhen you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use \nit in other aspects of your life. Your reflections will last {duration} seconds.";
    }

    protected override string GetEndingMessage()
    {
        return $"Good job! \n\nYou have completed the Reflection Activity for {duration} seconds.\n";
    }

    protected override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        Random rnd = new Random();

        // Shuffle prompts and questions
        var shuffledPrompts = prompts.OrderBy(x => rnd.Next()).ToArray();
        var shuffledQuestions = questions.OrderBy(x => rnd.Next()).ToArray();

        int promptIndex = 0;
        int questionIndex = 0;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            if (promptIndex < shuffledPrompts.Length)
            {
                Console.WriteLine(shuffledPrompts[promptIndex++]);
                Console.WriteLine();
                Console.WriteLine("Press enter to begin receiving questions to ponder: ");
                Console.ReadLine();
                Pause(1);
            }

            while (questionIndex < shuffledQuestions.Length && (DateTime.Now - startTime).TotalSeconds < duration)
            {
                Console.WriteLine(shuffledQuestions[questionIndex++]);
                Pause(10); // Pause for 10 seconds
            }
        }
    }
}
