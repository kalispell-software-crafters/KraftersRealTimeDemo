namespace KraftersRealTimeDemo;

public interface IAutomationComponent
{
     Task<String> Setup(String param);
     Task<String> Process(CancellationToken cancellationToken);
     Task<String> Teardown();
}