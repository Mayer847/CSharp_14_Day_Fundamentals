var service = new ApplicationService(new ConsoleNotifier());
service.Submit("Atos", "Testing Specialist");

public interface INotifier
{
    void Send(string message);
}

public class ConsoleNotifier : INotifier
{
    public void Send(string message) => Console.WriteLine($"NOTIFICATION: {message}");
}

public class ApplicationService
{
    private readonly INotifier notifier;

    public ApplicationService(INotifier notifier)
    {
        this.notifier = notifier;
    }

    public void Submit(string company, string role)
    {
        if (string.IsNullOrWhiteSpace(company) || string.IsNullOrWhiteSpace(role))
            throw new ArgumentException("Company and role are required.");
        notifier.Send($"Application submitted: {company} - {role}");
    }
}
