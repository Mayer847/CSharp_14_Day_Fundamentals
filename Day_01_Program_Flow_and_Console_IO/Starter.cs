Console.Write("Name: ");
string? name = Console.ReadLine()?.Trim() ?? "";

// TODO: ask for current role and target role.
Console.Write("Current Role:");
string? currentRole = Console.ReadLine()?.Trim() ?? "";
Console.Write("Target Role:");
string? targetRole = Console.ReadLine()?.Trim() ?? "";

// TODO: replace blank values with "Not provided".
name = string.IsNullOrWhiteSpace(name) ? "Not provided" : name;
currentRole = string.IsNullOrWhiteSpace(currentRole) ? "Not provided" : currentRole;
targetRole = string.IsNullOrWhiteSpace(targetRole) ? "Not provided" : targetRole;

// TODO: print a career card.
Console.WriteLine($"\n{name}");
Console.WriteLine($"Current: {currentRole}");
Console.WriteLine($"Target: {targetRole}");
Console.WriteLine($"Date: {DateTime.Today:yyyy_dd_MM}");