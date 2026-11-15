using System.Diagnostics;

namespace KraftersRealTimeDemo;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Stopwatch stopwatch = new Stopwatch();

        IAutomationComponent component = new Component1();
        await component.Setup("param");
        stopwatch.Start();
        String message = await component.Process(CancellationToken.None);
        stopwatch.Stop();
        Console.WriteLine($"time await = {stopwatch.Elapsed.TotalMilliseconds}");

        stopwatch.Reset();
        stopwatch.Start();
        _ = component.Process(CancellationToken.None);
        stopwatch.Stop();
        Console.WriteLine($"time fire and forget = {stopwatch.Elapsed.TotalMilliseconds}");

        
        
        
        await component.Teardown();
        
        

      }
}