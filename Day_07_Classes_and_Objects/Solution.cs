var applications = new List<JobApplication>
{
    new("Atos", "Testing Specialist", 82),
    new("Example Co", "Senior Automation Engineer", 45),
    new("Remote Product", "Junior QA", 78)
};

foreach (JobApplication app in applications.Where(a => a.IsPriority()))
    Console.WriteLine($"{app.Company} - {app.Role}: {app.MatchScore}%");

public class JobApplication
{
    public string Company { get; }
    public string Role { get; }
    public int MatchScore { get; }
    public string Status { get; private set; } = "Not Applied";

    public JobApplication(string company, string role, int matchScore)
    {
        if (matchScore is < 0 or > 100) throw new ArgumentOutOfRangeException(nameof(matchScore));
        Company = company;
        Role = role;
        MatchScore = matchScore;
    }

    public bool IsPriority() => MatchScore >= 75;
    public void MarkApplied() => Status = "Applied";
}
