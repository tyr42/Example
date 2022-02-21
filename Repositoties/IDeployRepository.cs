using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOPS_API.Models;

namespace WOPS_API.Repositoties
{
    public interface IDeployRepository
    {
        public string Test();
        public string GetHrefVdc();
        public Deployment AddDeployment(Deployment deployment);
        public void UpdateStatus(int id, string newStatus);
        public string GetStatus(int id);

        public Deployment GetById(int id);
        public void UpdateById(int id, Deployment deployment);

        public string GetToken(int id);
        public void SetToken(int id, string str);

        public string GetAcceptDefault(int id);
    }
}
