using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.DTO
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
 
        public int Cores { get; set; }
        public int RamInGb { get; set; }
        public int HddInGb { get; set; }

        public Template(int id, string name, int cores, int ramInGb, int hddInGb)
        {
            Id = id;
            Name = name;
            Cores = cores;
            RamInGb = ramInGb;
            HddInGb = hddInGb;
        }
    }

    public class TemplatesTransfer
    {
        public List<Template> List { get; set; }

        public TemplatesTransfer(List<Template> te)
        {
            List = te;
        }
    }
}
