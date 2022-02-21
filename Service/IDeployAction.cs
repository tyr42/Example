using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WOPS_API.Models;

namespace WOPS_API.Service
{
    public interface IDeployAction
    {
        Task DeployAsync(Deployment deployment, CancellationToken token);
    }
}
