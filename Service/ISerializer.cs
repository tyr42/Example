using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Service
{
    public interface ISerializer
    {
        public string Serialize<T>(T dataToSerialize);
        public T Deserialize<T>(string input) where T : class;
    }
}
