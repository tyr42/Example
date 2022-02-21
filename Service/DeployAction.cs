using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WOPS_API.Models;
using WOPS_API.Repositoties;
using WOPS_API.Util;

namespace WOPS_API.Service
{
    public class DeployAction : IDeployAction
    {
        
        private ILogger<DeployAction> logger;
        private readonly IDeployRepository deployRepository;
        private readonly IInfoRepository infoRepository;
        public Requests requests;
        public ProcessData processData;
        private readonly ISerializer serializer;

        public DeployAction(ILogger<DeployAction> logger, IDeployRepository deployRepository, IInfoRepository infoRepository, ISerializer serializer)
        {
            this.logger = logger;
            this.deployRepository = deployRepository;
            this.infoRepository = infoRepository;
            this.requests = new Requests(deployRepository);
            this.processData = new ProcessData(serializer, deployRepository, infoRepository, requests);
            this.serializer = serializer;
            //serializer = new Serializer();
        }

        //public DeployAction(ILogger<DeployAction> logger, IDeployRepository deployRepository)
        //{
        //    this.logger = logger;
        //    this.deployRepository = deployRepository;
        //    requests = new Requests(deployRepository);
        //    processData = new ProcessData(serializer, deployRepository, requests, processData);
        //    serializer = new Serializer();
        //}

        public async Task DeployAsync(Deployment deployment, CancellationToken token)
        {
            using(var client = new HttpClient())
            {
                string urlGetNetwork = deployment.HrefVapp + "/networkConfigSection";
                string resp = await requests.GetRequest(urlGetNetwork, deployment.AcceptDefault, client, deployment.BearerToken);
                deployment.Network = processData.ProcessNetworkInfo(resp);

                //create basic VM
                string urlCreateVM = deployment.HrefVapp + "/action/recomposeVApp";
                string body = processData.CreateBodyForDeployVM(deployment);
                resp = await requests.PostRequest(urlCreateVM, deployment.AcceptDefault, client, body, deployment.BearerToken);
                string taskToMonitor = processData.ProcessCreateVmResponse(resp);
                resp = await processData.MonitorTask(taskToMonitor, deployment.AcceptDefault, client, deployment.BearerToken);

                //find your VM for adjusting
                //todo CheckUserinput() in Controller
                string urlGetVmList = "https://vcloud.claranet.de/api/query?type=vm&format=records&page=1&pageSize=15&filterEncoded=true&filter=((isAutoNature==false);(isVAppTemplate==false);(container==" + deployment.IdVappUrn + "))&sortAsc=name&links=true";
                resp = await requests.GetRequest(urlGetVmList, deployment.AcceptDefault, client, deployment.BearerToken);
                processData.ProcessGetVmList(resp, deployment);
                
                //PowerOn VM
                resp = await requests.PowerOn(deployment.HrefVm, client, deployment);
                taskToMonitor = processData.ProcessPowerOn(resp);
                resp = await processData.MonitorTask(taskToMonitor, deployment.AcceptDefault, client, deployment.BearerToken);

                //Modify according to user input
                string modBody = processData.CreateBodyForModification(deployment.Configuration.ContainerName, deployment.Configuration.Description, deployment.Configuration.Cores, deployment.Configuration.Ram, deployment.Configuration.Hdd, deployment.HardwareVersionHref, deployment.HardwareVersionValue);
                string hrefToModify2 = deployment.HrefVm + "/action/reconfigureVm";
                resp = await requests.PostRequest(hrefToModify2, deployment.AcceptDefault, client, modBody, deployment.BearerToken);
                taskToMonitor = processData.ProcessModifyVM(resp);
                resp = await processData.MonitorTask(taskToMonitor, deployment.AcceptDefault, client, deployment.BearerToken);

                //set backup info in metadata
                //Set MetaData
                string vm_id = deployment.IdVm;
                string hrefMeta = @"https://vcloud.claranet.de/api/vApp/" + vm_id + "/metadata/";
                string metaBody = processData.CreateBodyForMetaData();

                resp = await requests.PostRequest(hrefMeta, deployment.AcceptDefault, client, metaBody, deployment.BearerToken);
                taskToMonitor = processData.ProcessMetaData(resp);
                resp = await processData.MonitorTask(taskToMonitor, deployment.AcceptDefault, client, deployment.BearerToken);

            }
        }
    }
}
