// TODO: create three JobApplication objects and print priorities.
// Create a JobApplication class with company, role, match score, status, and an IsPriority() method. 
// Create three objects and print priority applications.
// required forces callers to initialize essential properties.
using System.Runtime.CompilerServices;

public class JobApplication
{
    // TODO: properties and IsPriority method.
    public string Company { get; }
    public string Role { get; }
    public int MatchScore { get; }
    public bool Status { get; }
    public JobApplication(string company, string role, int matchScore, bool status = false)
    {
        Company = company;
        Role = role;
        MatchScore = matchScore;
        Status = status;
    }

    public bool IsPriority()
    {
        if (MatchScore >= 80 && Status) return true;
        false;
    }


}
