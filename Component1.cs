namespace KraftersRealTimeDemo;

public class Component1 : IAutomationComponent
{
    public async Task<string> Setup(string param)
    {
        return "Not implemented";
    }

    public async Task<String> Process(CancellationToken cancellationToken)
    {
        Console.WriteLine("Component1 Processed started");
        await Task.Delay(TimeSpan.FromSeconds(3), cancellationToken);
        Console.WriteLine("Component1 Processed end ");
        return "Component1 Processed";
    }


    public async Task<string> Teardown()
    {
        return "Not implemented";
    }
}