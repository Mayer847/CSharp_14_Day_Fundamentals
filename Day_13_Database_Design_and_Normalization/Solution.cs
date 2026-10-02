var company = new Company(1, "Atos", "https://atos.net");
var application = new JobApplication(1, company.Id, "Testing Specialist", "Applied");
var interviews = new List<Interview>
{
    new(1, application.Id, new DateTime(2026, 10, 10, 10, 0, 0)),
    new(2, application.Id, new DateTime(2026, 10, 15, 14, 0, 0))
};

Console.WriteLine($"{company.Name}: {application.Role}, interviews: {interviews.Count}");

public record Company(int Id, string Name, string Website);
public record JobApplication(int Id, int CompanyId, string Role, string Status);
public record Interview(int Id, int ApplicationId, DateTime ScheduledAt);

/* SQL shape:
CREATE TABLE Companies (
  Id INTEGER PRIMARY KEY,
  Name TEXT NOT NULL,
  Website TEXT NULL
);
CREATE TABLE Applications (
  Id INTEGER PRIMARY KEY,
  CompanyId INTEGER NOT NULL REFERENCES Companies(Id),
  Role TEXT NOT NULL,
  Status TEXT NOT NULL
);
CREATE TABLE Interviews (
  Id INTEGER PRIMARY KEY,
  ApplicationId INTEGER NOT NULL REFERENCES Applications(Id),
  ScheduledAt TEXT NOT NULL
);
*/
