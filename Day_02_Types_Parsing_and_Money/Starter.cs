Console.Write("Monthly income: ");
string? input = Console.ReadLine();

// TODO: safely parse a decimal.
// TODO: reject negative values.
if (!decimal.TryParse(input, out decimal income) || income < 0)
{
    Console.WriteLine("Please enter a valid non-negative amount!");
    return;
}

// TODO: calculate tithe, remaining income, yearly tithe.
const decimal titheRate = 0.1m;
decimal tithe = income * titheRate;
decimal remaining = income - tithe;
decimal yearlyTithe = tithe * 12;

// Console.WriteLine($"Income: {income}");
Console.WriteLine($"Tithe: {tithe}");
Console.WriteLine($"Remaining: {remaining}");
Console.WriteLine($"Yearly Tithe {yearlyTithe}");