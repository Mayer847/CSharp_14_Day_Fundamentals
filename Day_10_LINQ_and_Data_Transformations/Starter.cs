var applications = new List<Application>
{
    new("Atos", "Testing Specialist", 82, false),
    new("Colonist", "QA Engineer", 74, true),
    new("Example", "QA Lead", 55, false),
    new("Product Co", "Junior QA", 79, false)
};

// TODO: filter, sort, transform and print.

public record Application(string Company, string Role, int Score, bool Applied);
