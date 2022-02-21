using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.DTO
{
   
    public class VApp
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public VApp(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class VAppsTransfer
    {
        public List<VApp> List { get; set; }

        public VAppsTransfer(List<VApp> va)
        {
            List = va;
        }
    }
}
