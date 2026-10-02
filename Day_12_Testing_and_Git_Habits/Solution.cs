Run("calculates ten percent", () =>
{
    AssertEqual(100m, CalculateTithe(1000m, 0.10m));
});

Run("zero income returns zero", () =>
{
    AssertEqual(0m, CalculateTithe(0m, 0.10m));
});

Run("negative income throws", () =>
{
    AssertThrows<ArgumentOutOfRangeException>(() => CalculateTithe(-1m, 0.10m));
});

Run("rate above one throws", () =>
{
    AssertThrows<ArgumentOutOfRangeException>(() => CalculateTithe(100m, 1.1m));
});

static decimal CalculateTithe(decimal income, decimal rate)
{
    if (income < 0) throw new ArgumentOutOfRangeException(nameof(income));
    if (rate is < 0 or > 1) throw new ArgumentOutOfRangeException(nameof(rate));
    return income * rate;
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

static void AssertThrows<TException>(Action action) where TException : Exception
{
    try { action(); }
    catch (TException) { return; }
    throw new Exception($"Expected {typeof(TException).Name}");
}
