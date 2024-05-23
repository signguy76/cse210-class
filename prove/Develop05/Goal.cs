// Base class for Goals
[Serializable]
public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    protected Goal() { }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract int RecordEvent();
    public abstract string DisplayStatus();
}