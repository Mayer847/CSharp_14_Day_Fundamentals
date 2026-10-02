Console.Write("Monthly income: ");
string? input = Console.ReadLine();

if (!decimal.TryParse(input, out decimal income) || income < 0)
{
    Console.WriteLine("Enter a valid non-negative amount.");
    return;
}

const decimal titheRate = 0.10m;
decimal tithe = income * titheRate;
decimal remaining = income - tithe;
decimal yearlyTithe = tithe * 12;

Console.WriteLine($"Tithe: {tithe:N2}");
Console.WriteLine($"Remaining: {remaining:N2}");
Console.WriteLine($"Yearly tithe: {yearlyTithe:N2}");
