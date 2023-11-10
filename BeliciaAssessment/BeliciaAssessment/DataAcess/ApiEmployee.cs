using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BeliciaAssessment.DataAcess
{
    public class ApiEmployee
    {
        public string Id { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Name { get; set; }

        public ApiEmployee(string id, string created, string updated, string name)
        {
            this.Id = id;
            this.Created = created;
            this.Updated = updated;
            this.Name = name;
        }
    }
}
