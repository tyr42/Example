using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models
{
  
        public class VM
        {
            public int Id { get; set; }
            public string VmId { get; set; }
            public string VmIdLong { get; set; }
            public string HardwareVersionValue { get; set; }
            public string HardwareVersionHref { get; set; }
            public string Name { get; set; }
            public string Href { get; set; }
            public string Description { get; set; }
            public int Cores { get; set; }
            public int Ram { get; set; }
            public int Hdd { get; set; }

            public VM(int id, string vmId, string vmIdLong, string hardwareVersionValue, string hardwareVersionHref, string name, string href, string description, int cores, int ram, int hdd)
            {
                Id = id;
                VmId = vmId;
                VmIdLong = vmIdLong;
                HardwareVersionValue = hardwareVersionValue;
                HardwareVersionHref = hardwareVersionHref;
                Name = name;
                Href = href;
                Description = description;
                Cores = cores;
                Ram = ram;
                Hdd = hdd;
            }
        }
    
}
