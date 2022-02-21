using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Extensions.Logging;
using WOPS_API.Service;

namespace WOPS_API.Service
{
    public class Serializer: ISerializer
    {
        private readonly ILogger<Serializer> logger;

        public Serializer(ILogger<Serializer> logger)
        {
            this.logger = logger;
        }

        //public Serializer()
        //{
        //}

        public string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new Utf8StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex.Message);
            }
            return null;
        }

        public T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
                return (T)ser.Deserialize(sr);
        }
    }
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding { get { return Encoding.UTF8; } }
    }
}
