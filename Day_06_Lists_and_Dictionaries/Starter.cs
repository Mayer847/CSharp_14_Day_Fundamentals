//Create a skill tracker. Add skill names and confidence from 1 to 5 to a dictionary. Print all skills and the weakest skill.
//If a skill is entered twice, update it instead of crashing.
using System.Runtime.CompilerServices;

var skills = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

// TODO: collect skills until "done".
// TODO: validate confidence 1-5.
// TODO: add or update the dictionary.
// TODO: print all skills and the weakest.

while (true)
{
    Console.Write("New skill name or done:");
    string skillName = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
    if (skillName is "")
    {
        Console.WriteLine("Please enter valid skill name or done");
        continue;
    }
    if (skillName == "done") break;
    if (!int.TryParse(Console.ReadLine(), out int confidence) || confidence is < 1 or > 5)
    {
        Console.WriteLine("Please enter confidence between 1 - 5");
        continue;
    }
    if (skills.ContainsKey(skillName))
    {
        skills[skillName] = confidence;
        continue;
    }
    skills.Add(skillName, confidence);
}

int count = skills.Count;
var weakestSkills = Dictionary<string, int>();
string weakestSkillName = "";
int weakestSkillConfidence = 0;
while (count > 0)
{
    if (skills[count] == 1)
    {
        weakestSkills =
    }
    Console.WriteLine(skills[count]);
    count--;
}

