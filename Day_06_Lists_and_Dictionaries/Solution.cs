var skills = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

while (true)
{
    Console.Write("Skill or done: ");
    string skill = Console.ReadLine()?.Trim() ?? "";
    if (skill.Equals("done", StringComparison.OrdinalIgnoreCase)) break;
    if (string.IsNullOrWhiteSpace(skill)) continue;

    Console.Write("Confidence (1-5): ");
    if (!int.TryParse(Console.ReadLine(), out int confidence) || confidence is < 1 or > 5)
    {
        Console.WriteLine("Invalid confidence.");
        continue;
    }
    skills[skill] = confidence;
}

foreach (var pair in skills.OrderBy(p => p.Key))
    Console.WriteLine($"{pair.Key}: {pair.Value}/5");

if (skills.Count > 0)
{
    var weakest = skills.MinBy(p => p.Value);
    Console.WriteLine($"Next focus: {weakest.Key} ({weakest.Value}/5)");
}
