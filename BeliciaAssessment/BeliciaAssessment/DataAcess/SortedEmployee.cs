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
    internal class SortedEmployee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ManagerId { get; set; }

        public SortedEmployee(string id, string name, string managerId)
        {
            this.Id = id;
            this.Name = name;
            this.ManagerId = managerId;
        }
    }
}
