using System.Text.Json;

var tracker = new ApplicationTracker();
await tracker.LoadAsync("applications.json");

while (true)
{
    Console.WriteLine("\n1 Add | 2 List | 3 Apply | 4 Stats | 0 Exit");
    string choice = Console.ReadLine() ?? "";

    if (choice == "0") break;
    if (choice == "1")
    {
        Console.Write("Company: "); string company = Console.ReadLine() ?? "";
        Console.Write("Role: "); string role = Console.ReadLine() ?? "";
        Console.Write("Match score: ");
        if (!int.TryParse(Console.ReadLine(), out int score)) { Console.WriteLine("Invalid score."); continue; }
        try { tracker.Add(company, role, score); }
        catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
    }
    else if (choice == "2")
    {
        foreach (var app in tracker.All.OrderByDescending(a => a.MatchScore))
            Console.WriteLine($"{app.Id} | {app.MatchScore}% | {app.Company} | {app.Role} | {app.Status}");
    }
    else if (choice == "3")
    {
        Console.Write("Application ID: ");
        if (Guid.TryParse(Console.ReadLine(), out Guid id) && tracker.MarkApplied(id))
            Console.WriteLine("Marked as applied.");
        else Console.WriteLine("Application not found.");
    }
    else if (choice == "4")
    {
        var stats = tracker.GetStats();
        Console.WriteLine($"Total: {stats.Total}, Applied: {stats.Applied}, Average: {stats.Average:F1}%");
    }
}

await tracker.SaveAsync("applications.json");

public class JobApplication
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Company { get; init; }
    public required string Role { get; init; }
    public int MatchScore { get; init; }
    public string Status { get; private set; } = "Not Applied";

    public void MarkApplied() => Status = "Applied";
}

public class ApplicationTracker
{
    private List<JobApplication> applications = [];
    public IReadOnlyList<JobApplication> All => applications;

    public void Add(string company, string role, int score)
    {
        if (string.IsNullOrWhiteSpace(company)) throw new ArgumentException("Company is required.");
        if (string.IsNullOrWhiteSpace(role)) throw new ArgumentException("Role is required.");
        if (score is < 0 or > 100) throw new ArgumentException("Score must be 0-100.");
        applications.Add(new JobApplication { Company = company.Trim(), Role = role.Trim(), MatchScore = score });
    }

    public bool MarkApplied(Guid id)
    {
        JobApplication? app = applications.FirstOrDefault(a => a.Id == id);
        if (app is null) return false;
        app.MarkApplied();
        return true;
    }

    public (int Total, int Applied, double Average) GetStats()
    {
        int total = applications.Count;
        int applied = applications.Count(a => a.Status == "Applied");
        double average = total == 0 ? 0 : applications.Average(a => a.MatchScore);
        return (total, applied, average);
    }

    public async Task SaveAsync(string path)
    {
        string json = JsonSerializer.Serialize(applications, new JsonSerializerOptions { WriteIndented = true });
        await File.WriteAllTextAsync(path, json);
    }

    public async Task LoadAsync(string path)
    {
        if (!File.Exists(path)) return;
        string json = await File.ReadAllTextAsync(path);
        applications = JsonSerializer.Deserialize<List<JobApplication>>(json) ?? [];
    }
}
