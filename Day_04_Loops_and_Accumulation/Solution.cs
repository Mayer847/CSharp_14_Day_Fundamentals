int count = 0;
int total = 0;
int highest = 0;
int strongMatches = 0;

while (true)
{
    Console.Write("Match percentage or done: ");
    string input = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
    if (input == "done") break;

    if (!int.TryParse(input, out int score) || score is < 0 or > 100)
    {
        Console.WriteLine("Invalid score.");
        continue;
    }

    count++;
    total += score;
    highest = Math.Max(highest, score);
    if (score >= 80) strongMatches++;
}

if (count == 0)
{
    Console.WriteLine("No scores entered.");
    return;
}

Console.WriteLine($"Count: {count}");
Console.WriteLine($"Average: {(double)total / count:F1}");
Console.WriteLine($"Highest: {highest}");
Console.WriteLine($"80% or higher: {strongMatches}");
