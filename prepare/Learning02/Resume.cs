class Resume
{
    public List<Job> _jobs = new List<Job>();
    public string _name;

    public void Display()
    {
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}