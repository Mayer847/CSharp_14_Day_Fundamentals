decimal income = ReadNonNegativeDecimal("Monthly income: ");
decimal tithe = CalculateTithe(income, 0.10m);
PrintSummary(income, tithe);

static decimal ReadNonNegativeDecimal(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        if (decimal.TryParse(Console.ReadLine(), out decimal value) && value >= 0)
            return value;
        Console.WriteLine("Enter a valid non-negative amount.");
    }
}

static decimal CalculateTithe(decimal income, decimal rate)
{
    if (rate is < 0 or > 1)
        throw new ArgumentOutOfRangeException(nameof(rate));
    return income * rate;
}

static void PrintSummary(decimal income, decimal tithe)
{
    Console.WriteLine($"Income: {income:N2}");
    Console.WriteLine($"Tithe: {tithe:N2}");
    Console.WriteLine($"Remaining: {income - tithe:N2}");
}
