using System.Text.Json;
using System.Text.Json.Serialization;

// Class to manage Goals
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

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
                _goals.Add(new SimpleGoal(name, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, points, target, bonusPoints));
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }

        int choice = int.Parse(Console.ReadLine());
        int pointsEarned = _goals[choice - 1].RecordEvent();
        _totalScore += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points! Total score: {_totalScore}");
    }

    public void SaveGoals(string filename)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter(), new GoalConverter() }
        };

        var data = new GoalData
        {
            Goals = _goals,
            TotalScore = _totalScore
        };
        File.WriteAllText(filename, JsonSerializer.Serialize(data, options));
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            var options = new JsonSerializerOptions
            {
                Converters = { new GoalConverter() }
            };

            var data = JsonSerializer.Deserialize<GoalData>(File.ReadAllText(filename), options);
            _goals = data.Goals;
            _totalScore = data.TotalScore;
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total score: {_totalScore}");
    }

    private class GoalData
    {
        public List<Goal> Goals { get; set; }
        public int TotalScore { get; set; }
    }
}
