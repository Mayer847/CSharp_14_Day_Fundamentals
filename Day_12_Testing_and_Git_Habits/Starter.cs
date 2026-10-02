Run("calculates ten percent", () =>
{
    decimal actual = CalculateTithe(1000m, 0.10m);
    AssertEqual(100m, actual);
});

// TODO: test zero income.
// TODO: test that invalid rates throw.

static decimal CalculateTithe(decimal income, decimal rate)
{
    throw new NotImplementedException();
}

static void Run(string name, Action test)
{
    try { test(); Console.WriteLine($"PASS: {name}"); }
    catch (Exception ex) { Console.WriteLine($"FAIL: {name} - {ex.Message}"); }
}

static void AssertEqual<T>(T expected, T actual)
{
    if (!EqualityComparer<T>.Default.Equals(expected, actual))
        throw new Exception($"Expected {expected}, got {actual}");
}
