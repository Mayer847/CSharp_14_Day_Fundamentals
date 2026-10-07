using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

Console.Write("Match percentage: ");
if (!int.TryParse(Console.ReadLine(), out int match) || match is < 0 or > 100) //this is not working with empty and numbers
{
    Console.WriteLine("Percentage must be between 0 and 100");
    return;
}

Console.Write("Remote? (yes/no): ");

string remoteText = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
if (remoteText is not ("yes" or "no"))
{
    Console.WriteLine("Please, type 'yes' or 'no'!");
    return;
}
string priority = remoteText == "yes" && match >= 80 ? "High" : match >= 65 ? "Medium" : "Skip";

Console.WriteLine($"Priority: {priority}");