using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.DTO
{
    public class UserInput
    {
        public int TemplateId { get; set; }
        public int VAppId { get; set; }
        public string ContainerName { get; set; }
        public string PcName { get; set; }
        public int Cores { get; set; }
        public string Description { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }

        public UserInput() { }
        public UserInput(int templateId, int vAppId, string containerName, string pcName, int cores, string description, int ram, int hdd)
        {
            TemplateId = templateId;
            VAppId = vAppId;
            ContainerName = containerName;
            PcName = pcName;
            Cores = cores;
            Description = description;
            Ram = ram;
            Hdd = hdd;
        }
    }
}
