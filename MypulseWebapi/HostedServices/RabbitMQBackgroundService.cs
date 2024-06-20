using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using MypulseWebapi.Services; 

namespace MypulseWebapi.HostedServices
{
    public class RabbitMQBackgroundService : BackgroundService
    {
        private readonly RabbitMQService _rabbitMQService;

        public RabbitMQBackgroundService(RabbitMQService rabbitMQService)
        {
            _rabbitMQService = rabbitMQService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();
            _rabbitMQService.StartConsumer();
            await Task.CompletedTask; // Keeps the service running
        }
    }

}
