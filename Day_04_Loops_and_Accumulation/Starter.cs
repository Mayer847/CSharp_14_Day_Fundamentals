int count = 0;
int total = 0;
int highest = 0;
int strongMatches = 0;



while (true)
{
    Console.Write("Match percentage or done: ");
    string input = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
    if (input == "done")
    {
        break;
    }
    if (!int.TryParse(input, out int match) || match is < 0 or > 100) // shortcircuit feature in C# 
    {
        Console.WriteLine("Percentage must be between 0 and 100.");
        continue;
    }
    count++;
    if (match >= 80) strongMatches++;
    // if (match > highest) highest = match;
    highest = Math.Max(match, highest);
    total += match;

}
if (count == 0)
{
    Console.Write("No scores entered!");
    return;
}

Console.WriteLine($"Count: {count}");
Console.WriteLine($"Average Match:{(double)total / count:F1}");
Console.WriteLine($"80% or higher: {strongMatches}");
Console.WriteLine($"Highest Match: {highest}");