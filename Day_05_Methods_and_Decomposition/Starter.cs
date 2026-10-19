// TODO: call three small methods from the main program.
// Refactor the tithe calculator into ReadNonNegativeDecimal, CalculateTithe, and PrintSummary methods.
using System.Reflection;
using System.Runtime.InteropServices;

decimal income = ReadNonNegativeDecimal("Enter income: ");
decimal tithe = CalculateTithe(income, 0.2m);
PrintSummary(income, tithe);
static decimal ReadNonNegativeDecimal(string prompt)
{
    while (true)
    {
        Console.Write(prompt);

        if (decimal.TryParse(Console.ReadLine(), out decimal result) && result >= 0)
        {
            return result;
        }
        Console.WriteLine("Please enter a valid non-negative amount!");
    }
}

static decimal CalculateTithe(decimal income, decimal rate)
{
    if (rate is > 1 or < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(rate));
    }
    return income * rate;
}

static void PrintSummary(decimal income, decimal tithe)
{
    Console.WriteLine($"Income:{income:N2}");
    Console.WriteLine($"Tithe:{tithe:N2}");
    Console.WriteLine($"Remaining:{income - tithe:N2}");
}
