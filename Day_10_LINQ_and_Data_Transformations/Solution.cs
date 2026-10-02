var applications = new List<Application>
{
    new("Atos", "Testing Specialist", 82, false),
    new("Colonist", "QA Engineer", 74, true),
    new("Example", "QA Lead", 55, false),
    new("Product Co", "Junior QA", 79, false)
};

List<string> priorities = applications
    .Where(a => !a.Applied && a.Score >= 75)
    .OrderByDescending(a => a.Score)
    .Select(a => $"{a.Score}% | {a.Company} | {a.Role}")
    .ToList();

priorities.ForEach(Console.WriteLine);

public record Application(string Company, string Role, int Score, bool Applied);
