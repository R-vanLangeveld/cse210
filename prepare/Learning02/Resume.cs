public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        for (int i = 0; i < 2; i ++)
        {
            _jobs[i].DisplayJobDetails();
        }
    }
}