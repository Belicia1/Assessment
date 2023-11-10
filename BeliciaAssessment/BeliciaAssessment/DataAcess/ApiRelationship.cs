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
    internal class ApiRelationship
    {
        public string Id { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string ManagerId { get; set; }
        public string ReporteeId { get; set; }

        public ApiRelationship(string id, string created, string updated, string managerId, string reporteeId)
        {
            this.Id = id;
            this.Created = created;
            this.Updated = updated;
            this.ManagerId = managerId;
            this.ReporteeId = reporteeId;
        }
    }
}
