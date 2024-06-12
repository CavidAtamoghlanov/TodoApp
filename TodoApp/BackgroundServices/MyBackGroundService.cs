

namespace TodoApp.BackgroundServices;

public class MyBackGroundService : IHostedService
{
    //public Task StartAsync(CancellationToken cancellationToken)
    //{
    //    Console.WriteLine("MyBackGroundService  Start...");
    //    return Task.CompletedTask;
    //}

    //public Task StopAsync(CancellationToken cancellationToken)
    //{
    //    Console.WriteLine("MyBackGroundService  Stop...");
    //    return Task.CompletedTask;
    //}

    private Timer _timer;
    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("MyBackGroundService  Start...");
        _timer = new Timer(Run, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(3));
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer.Dispose();
        Console.WriteLine("MyBackGroundService  Stop...");
        return Task.CompletedTask;
    }


    public void Run(object? obj)
    {
        Console.WriteLine("Hakuna Matida");
    }
}
