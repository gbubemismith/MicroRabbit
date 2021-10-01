using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MicroRabbit.Banking.Api.Workers
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public Worker(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var scopedService = scope.ServiceProvider.GetRequiredService<IScopedService>();
                        scopedService.Write();
                        Console.WriteLine("In worker service");

                        await Task.Delay(1000, stoppingToken);
                    }

                }
                catch (OperationCanceledException)
                {

                    return;
                }
            }
        }
    }

    public interface IScopedService
    {
        void Write();
    }

    public class MyScopedService : IScopedService
    {
        public void Write()
        {
            Console.WriteLine("In my scoped service");
        }
    }
}