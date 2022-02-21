using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOPS_API.Models.DTO;

namespace WOPS_API.Repositoties
{
    public interface IInfoRepository
    {
        public void SetBearer(string newBearer);
        public string GetBearer();
        public string GetAccept();
        public List<VApp> getAllVApps();
        public void SetAllVApps(List<VApp> list);
        public void AddVApp(VApp vApp);
        public VApp GetVApp(int id);

        public List<Template> getAllTemplates();
        public void SetAllTemplates(List<Template> list);
        public void AddTemplate(Template temp);
        public Template GetTemplate(int id);



    }
}
