Console.Write("Match percentage: ");
if (!int.TryParse(Console.ReadLine(), out int match) || match is < 0 or > 100)
{
    Console.WriteLine("Percentage must be between 0 and 100.");
    return;
}

Console.Write("Remote? (yes/no): ");
string remoteText = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
if (remoteText is not ("yes" or "no"))
{
    Console.WriteLine("Enter yes or no.");
    return;
}

bool isRemote = remoteText == "yes";
string priority = match >= 80 && isRemote
    ? "High"
    : match >= 65 ? "Medium" : "Skip";

Console.WriteLine($"Priority: {priority}");
