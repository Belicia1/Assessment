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
using System.ComponentModel.Design;

namespace BeliciaAssessment.DataAcess
{
    public class ApiData
    {
        public async Task<string> ApiDataAsyncEmployee()
        {
            string apiUrl = "https://interviewer-service.gl7ouskkmcjf2.us-east-1.cs.amazonlightsail.com/api/employee-sorter/get-employees";
            string candidateToken = "q5mxn1nlniwodaup05x6156q";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("candidate-token", candidateToken);

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        return content;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<string> ApiAsyncDataRelationship()
        {
            string apiUrl = "https://interviewer-service.gl7ouskkmcjf2.us-east-1.cs.amazonlightsail.com/api/employee-sorter/get-reporting-relationship";

            string candidateToken = "q5mxn1nlniwodaup05x6156q";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("candidate-token", candidateToken);

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        return content;
                    }
                    else
                    {
                        string statusCode = Convert.ToString(response.StatusCode);
                        return statusCode;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
        public async Task PostDataAsync()
        {
            string apiUrl = "https://interviewer-service.gl7ouskkmcjf2.us-east-1.cs.amazonlightsail.com/api/employee-sorter/test";

            string jsonData = "{ \"key\": \"value\" }";

            string candidateToken = "q5mxn1nlniwodaup05x6156q";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("candidate-token", candidateToken);
                    
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    // Make a POST request
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // Check if the request was successful (status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and display the response content as a string
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseContent);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }

            }
        }
    }
}

