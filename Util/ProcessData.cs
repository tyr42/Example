using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WOPS_API.Models;
using WOPS_API.Models.DTO;
using WOPS_API.Models.DTO_vCloud;
using WOPS_API.Repositoties;
using WOPS_API.Service;

namespace WOPS_API.Util
{
    public class ProcessData
    {
        private ISerializer serializer;
        private readonly IDeployRepository deployRepository;
        private readonly IInfoRepository infoRepository;
        public Requests requests;

        public ProcessData(ISerializer serializer, IDeployRepository deployRepository, IInfoRepository infoRepository, Requests requests)
        {
            this.serializer = serializer;
            this.deployRepository = deployRepository;
            this.infoRepository = infoRepository;
            this.requests = requests;
        }

        public void ProcessTemplateList(string resp)
        {
            List<Template> templates = new List<Template>();
            WOPS_API.Models.DTO_vCloud.GetTemplateResponse.QueryResultRecords templateList = serializer.Deserialize<WOPS_API.Models.DTO_vCloud.GetTemplateResponse.QueryResultRecords>(resp);

            for (int i = 0; i < templateList.VAppTemplateRecord.Length; i++)
            {
                string id_Template = "";
                string href = templateList.VAppTemplateRecord[i].href;
                string getPosition = "api/vAppTemplate/";
                int pos = href.IndexOf(getPosition);
                if (pos != -1)
                {
                    id_Template = href.Substring(pos + getPosition.Length);
                }

                templates.Add(new Template(
                    i,
                    templateList.VAppTemplateRecord[i].name,
                    templateList.VAppTemplateRecord[i].numberOfCpus,
                    templateList.VAppTemplateRecord[i].memoryAllocationMB / 1024,
                    (int)templateList.VAppTemplateRecord[i].storageKB / (1024 * 1024))
                    );
            }
            infoRepository.SetAllTemplates(templates);
        }

        public void ProcessVAppList(string resp)
        {
            List<VApp> vApps = new List<VApp>();
            WOPS_API.Models.DTO_vCloud.GetVappsResponse.QueryResultRecords vAppList = serializer.Deserialize<WOPS_API.Models.DTO_vCloud.GetVappsResponse.QueryResultRecords>(resp);

            for (int i = 0; i < vAppList.VAppRecord.Length; i++)
            {
                VApp v1 = new VApp(i, vAppList.VAppRecord[i].name);
                vApps.Add(v1);
            }
            infoRepository.SetAllVApps(vApps);
        }

        public string CreateBodyForMetaData()
        {
            //todo better way to do it....
            string path = "D:/Repos/wibu/vApp/vApp/Console2/metaUpdate.txt";
            string metaXml = File.ReadAllText(path);
            return metaXml;
        }

        public string ProcessMetaData(string resp)
        {
            WOPS_API.Models.DTO_vCloud.SetMetaData.SetMetaDataResponse myTask = serializer.Deserialize<WOPS_API.Models.DTO_vCloud.SetMetaData.SetMetaDataResponse>(resp);
            string href = myTask.href;
            return href;
        }

        public string ProcessModifyVM(string resp)
        {
            WOPS_API.Models.DTO_vCloud.ModResponse.ModifyVmResponse myTask = serializer.Deserialize<WOPS_API.Models.DTO_vCloud.ModResponse.ModifyVmResponse>(resp);
            string href = myTask.href;
            return href;
        }

        public string CreateBodyForModification(string name, string desc, int cores, int ram, int hdd, string hwVersionHref, string hwVersionValue)
        {
            WOPS_API.Models.DTO_vCloud.VmMod.VmMod vmMod = new WOPS_API.Models.DTO_vCloud.VmMod.VmMod(name, desc, cores, ram, hdd, hwVersionHref, hwVersionValue);
            string body = serializer.Serialize<WOPS_API.Models.DTO_vCloud.VmMod.VmMod>(vmMod);
            return body;
        }

        public string ProcessPowerOn(string resp)
        {
            WOPS_API.Models.DTO_vCloud.POR.PowerOnResponse myTask = serializer.Deserialize<WOPS_API.Models.DTO_vCloud.POR.PowerOnResponse>(resp);
            return myTask.href;
        }

        public void ProcessGetVmList(string response, Deployment deployment)
        {
            GetVmList result = serializer.Deserialize<GetVmList>(response);
            List<VM> vmList = new List<VM>();
            VM vm;
            for (int i = 0; i < result.VMRecord.Length; i++)
            {
                string hrefTemp = result.VMRecord[i].href;
                string vmId = "";
                string vmIdLong = "";
                string hrefvm = "";
                string findIndex = "api/vApp/vm-";
                int index = hrefTemp.IndexOf(findIndex);
                if (index != -1)
                {
                    hrefvm = result.VMRecord[i].href;
                    vmId = hrefvm.Substring(index + findIndex.Length);
                    vmIdLong = "urn:vcloud:vm:" + hrefvm.Substring(index + findIndex.Length);
                }
                string hwVersionValue = "vmx-" + result.VMRecord[i].hardwareVersion.ToString();
                string hwVersionHref = "https://vcloud.claranet.de/api/vdc/2dade109-3233-4f7e-b746-e3825f044796/hwv/" + hwVersionValue;
                vm = new VM(i, vmId, vmIdLong, hwVersionValue, hwVersionHref, result.VMRecord[i].name, result.VMRecord[i].href, result.VMRecord[i].description, result.VMRecord[i].numberOfCpus, result.VMRecord[i].memoryMB, result.VMRecord[i].totalStorageAllocatedMb);
                vmList.Add(vm);
                //should VmList be in Repository or just for this class???
            }
            VM vm2 = vmList.FirstOrDefault(o => o.Name == deployment.Configuration.ContainerName);
            deployment.HrefVm = vm2.Href;
            deployment.HardwareVersionHref = vm2.HardwareVersionHref;
            deployment.HardwareVersionValue = vm2.HardwareVersionValue;
        }


        public async Task<string> MonitorTask(string urlToMonitor, string accept, HttpClient client, string token)
        {
            string status = "";
            while (true)
            {
                string res = await requests.GetRequest(urlToMonitor, accept, client, token);
                status = serializer.Deserialize<CheckTaskStatus>(res).status;
                if (status == "success")
                {
                    break;
                }
            }
            return "";
        }

        public string ProcessNetworkInfo(string resp)
        {
            try
            {
                NetworkConfiguration configuration = serializer.Deserialize<NetworkConfiguration>(resp);
                return configuration.NetworkConfig.networkName;
            }
            catch (Exception)
            {
                //handle exception
                throw;
            }
        }

        public string ProcessCreateVmResponse(string resp)
        {
            //to implement!!!
            return "";
        }

        public string CreateBodyForDeployVM(Deployment deployment)
        {
            try
            {
                DeployBody createParams = new DeployBody(
                deployment.HrefTemplate,
                deployment.IdTemplate,
                deployment.Configuration.PcName,
                deployment.Network,
                 deployment.Configuration.Description,
                deployment.Configuration.ContainerName,
                 true,
                false);

                //Serialize
                string body = serializer.Serialize<DeployBody>(createParams);

                return body;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Deployment TransformData(Deployment deployment, UserInput info)
        {
            //deployment.BearerToken = bearerToken;
            deployment.Configuration.Cores = info.Cores;
            deployment.Configuration.Description = info.Description;
            deployment.Configuration.Hdd = info.Hdd;
            deployment.Configuration.ContainerName = info.ContainerName;
            deployment.Configuration.PcName = info.PcName;
            deployment.Configuration.Ram = info.Ram;
            //info has the ids of the  vApp/Template in the list
            // in deployment the ids are strings!!!
           // deployment.HrefTemplate = infoRepository.getAllTemplates().FirstOrDefault(o => o.Id == info.TemplateId).Href_Template;
            string getPosition = "api/vAppTemplate/";
            int pos = deployment.HrefTemplate.IndexOf(getPosition);
            if (pos != -1)
            {
                deployment.IdTemplate = deployment.HrefTemplate.Substring(pos + getPosition.Length);
            }

            //deployment.HrefVapp = infoRepository.getAllVApps().FirstOrDefault(o => o.Id == info.VAppId).Href_vApp;

            getPosition = "api/vApp/";
            pos = deployment.HrefVapp.IndexOf(getPosition);
            if (pos != -1)
            {
                deployment.IdVapp = deployment.HrefVapp.Substring(pos + getPosition.Length);
            }

            string test432 = GetSubstrinfAfter(deployment.HrefVapp, "api/vApp/vapp-");
            deployment.IdVappUrn = "urn:vcloud:vapp:" + test432;

            return deployment;
        }

        public string GetSubstrinfAfter(string source, string marker)
        {
            string result = "";
            int index = source.IndexOf(marker);
            if (index != -1)
            {
                result = source.Substring(index + marker.Length);
            }
            return result;
        }
    }
}
