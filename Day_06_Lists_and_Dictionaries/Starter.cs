//Create a skill tracker. Add skill names and confidence from 1 to 5 to a dictionary. Print all skills and the weakest skill.
//If a skill is entered twice, update it instead of crashing.

var skills = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

// TODO: collect skills until "done".
// TODO: validate confidence 1-5.
// TODO: add or update the dictionary.
// TODO: print all skills and the weakest.

while (true)
{
    Console.Write("Skill name or done:");
    string skillName = Console.ReadLine()?.Trim() ?? "";
    if (skillName.Equals("done", StringComparison.OrdinalIgnoreCase)) break;

    if (string.IsNullOrWhiteSpace(skillName))
    {
        Console.WriteLine("Please enter valid skill name or done");
        continue;
    }

    int confidence;
    while (true)
    {
        Console.Write("Confidence Level 1-5: ");
        if (int.TryParse(Console.ReadLine(), out int confidence) || confidence is >= 1 or <= 5)
        {
            break;
        }
        Console.WriteLine("Please enter confidence between 1 - 5");
    }
    skills[skillName] = confidence;

}


// bool flag = false;

foreach (var (skillName, confidence) in skills.OrderBy(p => p.Key))
{
    Console.WriteLine($"{skillName}: {confidence}/5");
}
if (skills.Count > 0)
{
    Console.WriteLine("Weakest Skills:");

    int minConfidence = skills.Min(p => p.Value);

    foreach (var (skillName, confidence) in skills.Where(p => p.Value == minConfidence))
    {
        Console.WriteLine($"{skillName}: {confidence}/5");
    }
}
