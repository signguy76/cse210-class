using System.ComponentModel.DataAnnotations;

class Resume
{
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}