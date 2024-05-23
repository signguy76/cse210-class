// Class to manage Goals
public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(name, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        int choice = int.Parse(Console.ReadLine());
        int pointsEarned = goals[choice - 1].RecordEvent();
        totalScore += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points! Total score: {totalScore}");
    }

    public void SaveGoals(string filename)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(GoalData));

        using (FileStream stream = new FileStream(filename, FileMode.Create))
        {
            GoalData data = new GoalData
            {
                Goals = goals,
                TotalScore = totalScore
            };

            serializer.Serialize(stream, data);
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GoalData));

            using (FileStream stream = new FileStream(filename, FileMode.Open))
            {
                GoalData data = (GoalData)serializer.Deserialize(stream);
                goals = data.Goals;
                totalScore = data.TotalScore;
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total score: {totalScore}");
    }

    [Serializable]
    public class GoalData
    {
        public List<Goal> Goals { get; set; }
        public int TotalScore { get; set; }
    }
}