using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOPS_API.Models.DTO;

namespace WOPS_API.Repositoties
{
    public class InfoRepository : IInfoRepository
    {
        public List<VApp> VAppList { get; set; }
        public List<Template> TemplateList { get; set; }

        public string Accept { get; set; }
        public string Bearer { get; set; }

        public InfoRepository()
        {
            VAppList = new List<VApp>();
            TemplateList = new List<Template>();
            Accept = "application/*+xml;version=34.0";
            Bearer = "";
        }
        public InfoRepository(List<VApp> vAppList, List<Template> templates, string accept, string bearer)
        {
            VAppList = vAppList;
            TemplateList = templates;
            Accept = accept;
            Bearer = bearer;
        }

        public void SetBearer(string newBearer)
        {
            Bearer = newBearer;
        }

        public string GetBearer()
        {
            return Bearer;
        }

        public string GetAccept()
        {
            return Accept;
        }

        public List<VApp> getAllVApps()
        {
            return VAppList;
        }

        public void SetAllVApps(List<VApp> list)
        {
            VAppList = list;
        }

        public void AddVApp(VApp vApp)
        {
            VAppList.Add(vApp);
        }

        public VApp GetVApp(int id)
        {
            return VAppList.FirstOrDefault(o => o.Id == id);
        }

        public List<Template> getAllTemplates()
        {
            return TemplateList;
        }

        public void SetAllTemplates(List<Template> list)
        {
            TemplateList = list;
        }

        public void AddTemplate(Template temp)
        {
            TemplateList.Add(temp);
        }

        public Template GetTemplate(int id)
        {
            return TemplateList.FirstOrDefault(o => o.Id == id);
        }
    }
}
