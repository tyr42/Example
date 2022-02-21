using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WOPS_API.Service;

namespace WOPS_API.Models
{
    public class DeployProcess
    {
        private Deployment deployment;
        private readonly IServiceScopeFactory serviceScopeFactory;

        public DeployProcess(Deployment deployment, IServiceScopeFactory serviceScopeFactory)
        {
            this.deployment = deployment;
            this.serviceScopeFactory = serviceScopeFactory;
        }

        public async ValueTask DeployVM(CancellationToken token)
        {
            using(var scope = serviceScopeFactory.CreateScope())
            {
                IDeployAction deployaction = scope.ServiceProvider.GetRequiredService<IDeployAction>();
                await deployaction.DeployAsync(deployment, token);
            }
        }

    }
}
