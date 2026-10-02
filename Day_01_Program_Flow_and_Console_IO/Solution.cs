Console.Write("Name: ");
string name = Console.ReadLine()?.Trim() ?? "";
Console.Write("Current role: ");
string currentRole = Console.ReadLine()?.Trim() ?? "";
Console.Write("Target role: ");
string targetRole = Console.ReadLine()?.Trim() ?? "";

name = string.IsNullOrWhiteSpace(name) ? "Not provided" : name;
currentRole = string.IsNullOrWhiteSpace(currentRole) ? "Not provided" : currentRole;
targetRole = string.IsNullOrWhiteSpace(targetRole) ? "Not provided" : targetRole;

Console.WriteLine($"\n{name}");
Console.WriteLine($"Current: {currentRole}");
Console.WriteLine($"Target: {targetRole}");
Console.WriteLine($"Created: {DateTime.Today:yyyy-MM-dd}");
