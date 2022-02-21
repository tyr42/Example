using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOPS_API.Models.DTO;

namespace WOPS_API.Models
{
    public class Deployment
    {
        public string HardwareVersionHref { get; set; }
        public string HardwareVersionValue { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }

        public string BearerToken { get; set; }
        public string HrefOrg { get; set; }

        public string HrefVdc { get { return "https://vcloud.claranet.de/api/vdc/2dade109-3233-4f7e-b746-e3825f044796"; } }
        public string HrefVapp { get; set; }
        public string HrefTemplate { get; set; }
        public string HrefVm { get; set; }

        public string IdTemplate { get; set; }
        public string IdVapp { get; set; }
        public string IdVappUrn { get; set; }
        public string IdVm { get; set; }
        public string IdLongVm { get; set; }
        public string AcceptDefault
        {
            get
            {
                return "application/*+xml;version=34.0";
            }
        }
        public string Network { get; set; }

        public UserInput Configuration { get; set; }

        public Deployment()
        {
            Configuration = new UserInput();
        }
    }
}
