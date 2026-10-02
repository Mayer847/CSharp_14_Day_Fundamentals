decimal balance = 1000m;
Console.Write("Withdraw amount: ");

if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    Console.WriteLine("Invalid amount.");
    return;
}

try
{
    balance = Withdraw(balance, amount);
    Console.WriteLine($"Remaining balance: {balance:N2}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

static decimal Withdraw(decimal balance, decimal amount)
{
    if (amount <= 0)
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive.");
    if (amount > balance)
        throw new InvalidOperationException("Insufficient balance.");
    return balance - amount;
}
