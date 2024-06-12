
using Microsoft.EntityFrameworkCore;
using TodoApp.Contexts;

namespace TodoApp.BackgroundServices;

public class SomeBackGroundService : BackgroundService
{
    private IDbContextFactory<AppDbContext> _context;

    public SomeBackGroundService(IDbContextFactory<AppDbContext> context)
    {
        _context = context;
    }

    private Timer _timer;
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _timer = new Timer(Run, null, TimeSpan.Zero, TimeSpan.FromSeconds(3));
        Console.WriteLine("SomeBackgroundService Execute....");
        return Task.CompletedTask;
    }

    public void Run(object? obj)
    {
        Console.WriteLine("Hakuna Matitiuuu");
    }
}
