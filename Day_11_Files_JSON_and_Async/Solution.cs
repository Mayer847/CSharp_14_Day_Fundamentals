using System.Text.Json;

var applications = new List<Application>
{
    new("Atos", "Testing Specialist", 82),
    new("Product Co", "Junior QA", 79)
};

var options = new JsonSerializerOptions { WriteIndented = true };
string json = JsonSerializer.Serialize(applications, options);
await File.WriteAllTextAsync("applications.json", json);

string loadedJson = await File.ReadAllTextAsync("applications.json");
List<Application> loaded = JsonSerializer.Deserialize<List<Application>>(loadedJson) ?? [];
Console.WriteLine($"Loaded {loaded.Count} applications.");

public record Application(string Company, string Role, int Score);
