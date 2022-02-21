using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WOPS_API.Service
{
    public class QueuedHostedService : BackgroundService
    {
        private readonly ILogger<QueuedHostedService> logger;

        public IBackgroundTaskQueue TaskQueue { get; }

        public QueuedHostedService(ILogger<QueuedHostedService> logger, IBackgroundTaskQueue takQueue)
        {
            this.logger = logger;
            TaskQueue = takQueue;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("Starting Backgound Service");
            await BackgroundProcess(stoppingToken);
        }

        private async Task BackgroundProcess(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var workItem = await TaskQueue.DequeueAsync(stoppingToken);
                try
                {
                    await workItem(stoppingToken);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message);
                }
            }
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Stopping Background Service");
            await base.StopAsync(cancellationToken);
        }
    }
}
