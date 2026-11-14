namespace KraftersRealTimeDemo;

public class Component1 : IAutomationComponent
{
    public async Task<string> Setup(string param)
    {
        return "Not implemented";
    }

    public async Task<String> Process(CancellationToken cancellationToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
        return "Component1 Processed";
    }


    public async Task<string> Teardown()
    {
        return "Not implemented";
    }
}