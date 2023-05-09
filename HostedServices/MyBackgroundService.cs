namespace HostedServices;

public class MyBackgroundService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.WriteLine($"MyBackgroundService - {DateTime.UtcNow:HH:mm:ss}");
            await Task.Delay(new TimeSpan(0, 0, 1));
        }
    }
}