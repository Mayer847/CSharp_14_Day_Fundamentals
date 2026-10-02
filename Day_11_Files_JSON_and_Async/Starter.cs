using System.Text.Json;

var applications = new List<Application>
{
    new("Atos", "Testing Specialist", 82),
    new("Product Co", "Junior QA", 79)
};

// TODO: serialize with indentation.
// TODO: save asynchronously.
// TODO: read and deserialize asynchronously.

public record Application(string Company, string Role, int Score);
