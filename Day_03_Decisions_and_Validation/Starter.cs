using System.Text.RegularExpressions;

Console.Write("Match percentage: ");
string? matchInput = Console.ReadLine();


// TODO: parse and validate percentage.
if (!int.TryParse(matchInput, out int matchPercentage) && String.IsNullOrWhiteSpace(remoteInput)) //this is not working with empty and numbers
{
    Console.WriteLine("Please, enter a valid input!");
    return;
}
Console.Write("Remote? (yes/no): ");
string? remoteInput = Console.ReadLine();
if (matchPercentage > 100 || matchPercentage < 0)
{
    Console.WriteLine("Please, enter a valid percentage!");
    return;
}
String remoteInputNormalized = remoteInput.ToLower();
if (remoteInputNormalized.StartsWith('y') || remoteInputNormalized.StartsWith('Y'))
{
    remoteInputNormalized = "yes";
}
else
{
    remoteInputNormalized = "no";
}

if (matchPercentage >= 80 && String.Equals(remoteInputNormalized, "yes"))
{
    Console.WriteLine("High");
    return;
}
if (matchPercentage >= 65)
{
    Console.WriteLine("Medium");
    return;
}
Console.WriteLine("Skip");
// TODO: normalize yes/no.
// TODO: calculate priority.
