int count = 0;
int total = 0;
int highest = 0;
int strongMatches = 0;

// TODO: loop until "done".
// TODO: ignore invalid numbers.
// TODO: update statistics and print the summary.
bool doneFlag = false;
while(!doneFlag)
{
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
    count++;
    if (match >=80) strongMatches++;
    
    Console.WriteLine("if Done please type 'done'");//check how to write "" inside "" lol
    doneFlag = (Console.ReadLine()?.Trim()??"") == "done";
}