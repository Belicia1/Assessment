using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BeliciaAssessment.DataAcess;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BeliciaAssessment
{
    class Program
    {
        static async Task Main()
        {

            List<SortedEmployee> sortEmp = new List<SortedEmployee>();   

            List<ApiEmployee> employees = await JsonConvertEmployee();

            List<ApiRelationship> relationship = new List<ApiRelationship>();

            foreach (ApiEmployee employee in employees)
            {
                var sorted = from emp in employees
                             join rel in relationship on emp.Id equals rel.ReporteeId
                             select new
                             {
                                 emp.Id,
                                 emp.Name,
                                 rel.ManagerId
                             };

                sortEmp.Add(sorted);
                
            }
        }

        public static async Task<List<ApiEmployee>> JsonConvertEmployee()
        {
            try
            {
                ApiData apiData = new ApiData();

                // Use async/await to get the data asynchronously
                string rawEmployeeData = await apiData.ApiDataAsyncEmployee();

                if (!string.IsNullOrEmpty(rawEmployeeData))
                {
                    // Deserialize the JSON array to a list of ApiEmployee
                    var employees = JsonConvert.DeserializeObject<List<ApiEmployee>>(rawEmployeeData);

                    return employees;
                }
                else
                {
                    return new List<ApiEmployee>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }

    }
}




