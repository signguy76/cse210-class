class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        // Initialize some sample prompts
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something that made you smile today?",
            "Describe a challenge you faced and how you overcame it.",
            "Write about a goal you're working towards.",
            "Reflect on a recent accomplishment.",
            "Share a random fact or interesting tidbit you learned today."
        };
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}