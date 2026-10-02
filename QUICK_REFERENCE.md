# Compact C# Reference

```csharp
// Variables
string name = "Mayer";
int count = 3;
double price = 19.5;
bool active = true;

// Nullable parsing
int? age = int.TryParse(Console.ReadLine(), out int parsed) ? parsed : null;

// Conditions
if (count > 0) { }
else if (count == 0) { }
else { }

// Loops
for (int i = 0; i < 3; i++) { }
foreach (string item in items) { }
while (condition) { }

// Method
static decimal Calculate(decimal amount, decimal rate = 0.10m)
    => amount * rate;

// Collections
var names = new List<string>();
var scores = new Dictionary<string, int>();

// Class
public class User
{
    public required string Name { get; init; }
    public bool Active { get; private set; }
    public void Activate() => Active = true;
}

// LINQ
var result = numbers.Where(n => n > 0).OrderBy(n => n).ToList();

// Exceptions
try { }
catch (InvalidOperationException ex) { Console.WriteLine(ex.Message); }

// Async
string text = await File.ReadAllTextAsync("file.txt");
```

## Naming

- Classes, methods, properties: `PascalCase`
- Local variables and parameters: `camelCase`
- Booleans should sound true/false: `isValid`, `hasAccess`
- Methods should describe actions: `CalculateTotal`, `FindUser`

## Debugging questions

1. What did I expect?
2. What actually happened?
3. What is the smallest input that reproduces it?
4. What values exist immediately before failure?
5. Which assumption was wrong?
