using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using WOPS_API.Models;
using WOPS_API.Models.DTO;
using WOPS_API.Repositoties;
using WOPS_API.Service;
using WOPS_API.Util;

namespace WOPS_API.Controllers
{
    public class DeployController : Controller
    {
        private readonly IDeployRepository deployRepository;
        private readonly IInfoRepository infoRepository;
        private readonly IServiceScopeFactory serviceScopeFactory;
        private readonly IBackgroundTaskQueue queue;

        static string DeployStatus;

        public Requests requests;
        public ProcessData processData;

        public DeployController(IDeployRepository deployRepository, IInfoRepository infiRepository, IServiceScopeFactory serviceScopeFactory, IBackgroundTaskQueue queue, ISerializer serializer)
        {
            this.deployRepository = deployRepository;
            this.infoRepository = infiRepository;
            this.serviceScopeFactory = serviceScopeFactory;
            this.queue = queue;
            this.requests = new Requests(deployRepository);
            this.processData = new ProcessData(serializer, deployRepository, infoRepository, new Requests(deployRepository));
            //DeployStatus = "initialized";
        }

        //GET DeployController/start
        public int Start()
        {
            DeployStatus = "basic1";
            StartDeployment(42);
            return 42;
        }

        //Get DeployController/Check
        public string Check()
        {
            if (DeployStatus is not null)
            {
                return DeployStatus;
            }
            return "fail";
        }

        private async void StartDeployment(int id)
        {
            int delay;
            Random rn = new Random();
            delay = rn.Next(2000, 5000);
            DeployStatus = "basic1";
            await Task.Delay(delay);
            delay = rn.Next(3000, 5000);
            DeployStatus = "basic2";
            await Task.Delay(delay);
            delay = rn.Next(4000, 7000);
            DeployStatus = "basic3";
            await Task.Delay(delay);
            DeployStatus = "rec1";
            await Task.Delay(delay);
            DeployStatus = "rec2";
            await Task.Delay(delay);
            DeployStatus = "meta1";
            await Task.Delay(delay);
            DeployStatus = "done";
        }

        //// GET: DeployController/Check

        //public string Check(int id)
        //{
        //    deployRepository.GetStatus(id);
        //    if (deployRepository.GetStatus(id) is not null)
        //    {
        //        return deployRepository.GetStatus(id);
        //    }
        //    return deployRepository.Test();

        //}

        // POST: DeployController/CreateVM

        public string CreateVM([FromBody] UserInput info)
        {
            if (ValidateUserInput(info))
            {
                //CreateVM
                return "ok";
            }
            return "not ok";
        }

        private bool ValidateUserInput(UserInput info)
        {
            int maxCores = 12;
            int maxRam = 32;
            int maxHdd = 500;
            bool valid = true;
            Template basicTemplate = infoRepository.GetTemplate(info.TemplateId);

            if (info.Cores < basicTemplate.Cores || info.Cores > maxCores ||
                info.Ram < basicTemplate.RamInGb || info.Ram > maxRam ||
                info.Hdd < basicTemplate.HddInGb || info.Hdd > maxHdd)
            {
                valid = false;
            }

            return valid;
        }

        private void UpdateTemplates()
        {
            List<Template> templates = infoRepository.getAllTemplates().ToList();
            if (templates.Count() == 0)
            {
                templates.Add(new Template(0, "- - - - -", 0, 0, 0));
                templates.Add(new Template(1, "Template one", 4, 8, 240));
                templates.Add(new Template(2, "Template two", 8, 8, 60));
                templates.Add(new Template(3, "Template three", 2, 16, 60));
                infoRepository.SetAllTemplates(templates);
            }
        }

        private void UpdateVApps()
        {
            List<VApp> vapps = infoRepository.getAllVApps().ToList();
            if (vapps.Count() == 0)
            {
                vapps.Add(new VApp(0, "- - - - -"));
                vapps.Add(new VApp(1, "first vApp"));
                vapps.Add(new VApp(2, "second vApp"));
                vapps.Add(new VApp(3, "third vApp"));
                infoRepository.SetAllVApps(vapps);
            }
        }


        public TemplatesTransfer GetAllTemplates()
        {
            try
            {
                UpdateTemplates();
                List<Template> templates = infoRepository.getAllTemplates();
                //List<Template> templates = new List<Template>();
                TemplatesTransfer temps = new TemplatesTransfer(templates);
                return temps;

            }
            catch (Exception e)
            {

                throw new Exception("GetAllTemplates failed", e);
            }
        }


        public Template GetTemplateById(int id)
        {
            UpdateTemplates();
            return infoRepository.GetTemplate(id);
        }

        public VAppsTransfer GetAllVApps()
        {
            try
            {

                UpdateVApps();
                List<VApp> va = infoRepository.getAllVApps();
                VAppsTransfer vat = new VAppsTransfer(va);
                return vat;
            }
            catch (Exception e)
            {

                throw new Exception("GetAppVapps failed", e);
            }
        }

        // GET: DeployController

        public ActionResult Index()
        {
            return View();
        }

    }
}
