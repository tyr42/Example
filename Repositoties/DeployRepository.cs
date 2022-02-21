using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOPS_API.Models;

namespace WOPS_API.Repositoties
{
    public class DeployRepository : IDeployRepository
    {
        private int newMaxId = 0;
        private List<Deployment> list = new List<Deployment>();
        private string hrefVdc = "https://vcloud.claranet.de/api/vdc/2dade109-3233-4f7e-b746-e3825f044796";

        public string Test()
        {
            return "tested";
        }
        public string GetHrefVdc()
        {
            return hrefVdc;
        }
        public Deployment AddDeployment(Deployment deployment)
        {
            Deployment depl = deployment;
            depl.Id = newMaxId++;
            list.Add(depl);
            return depl;
        }

        public string GetAcceptDefault(int id)
        {
            Deployment depl = list.FirstOrDefault(o => o.Id == id);
            if (depl is not null)
            {
                return depl.AcceptDefault;
            }
            //Handle error
            return "";
        }

        public Deployment GetById(int id)
        {
            Deployment depl = list.FirstOrDefault(o => o.Id == id);
            if (depl is not null)
            {
                return depl;
            }
            return null;
        }

        public string GetStatus(int id)
        {
            Deployment depl = list.FirstOrDefault(o => o.Id == id);
            if (depl is not null)
            {
                return depl.Status;
            }
            return null;
        }

        public string GetToken(int id)
        {
            Deployment depl = list.FirstOrDefault(o => o.Id == id);
            if (depl is not null)
            {
                return depl.BearerToken;
            }
            return null;
        }

        public void SetToken(int id, string str)
        {
            Deployment depl = list.FirstOrDefault(o => o.Id == id);
            if (depl is not null)
            {
                depl.BearerToken = str; ;
            }

        }

        public void UpdateById(int id, Deployment deployment)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(int id, string newStatus)
        {
            Deployment depl = list.FirstOrDefault(o => o.Id == id);
            if (depl is not null)
            {
                depl.Status = newStatus;
            }

        }
    }
}
