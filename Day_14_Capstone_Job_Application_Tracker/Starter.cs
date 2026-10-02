using System.Text.Json;

var tracker = new ApplicationTracker();
await tracker.LoadAsync("applications.json");

while (true)
{
    Console.WriteLine("\n1 Add | 2 List | 3 Apply | 4 Stats | 0 Exit");
    string choice = Console.ReadLine() ?? "";
    // TODO: implement menu operations.
    if (choice == "0") break;
}

await tracker.SaveAsync("applications.json");

public class JobApplication
{
    // TODO
}

public class ApplicationTracker
{
    // TODO
    public Task LoadAsync(string path) => Task.CompletedTask;
    public Task SaveAsync(string path) => Task.CompletedTask;
}
