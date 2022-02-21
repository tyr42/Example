using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WOPS_API.Models;
using WOPS_API.Models.Exceptions;
using WOPS_API.Repositoties;

namespace WOPS_API.Util
{
    public class Requests
    {
        private readonly IDeployRepository deployRepository;

        public Requests(IDeployRepository deployRepository)
        {
            this.deployRepository = deployRepository;
        }

        public async Task<string> PowerOn(string url, HttpClient client, Deployment deployment)
        {
            string newUrl = url + "/power/action/powerOn";
            string resp = await PostRequest(newUrl, deployment.AcceptDefault, client, "", deployment.BearerToken);
            return resp;
        }

        public async Task<string> GetRequest(string url, string accept, HttpClient client, string bearerToken)
        {
            string responsestring;
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                //Token in Controller or Repository???
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
                requestMessage.Headers.Add("Accept", accept);
                HttpResponseMessage response = await client.SendAsync(requestMessage);
                responsestring = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    throw new VcloudRestException(response.StatusCode.ToString(), responsestring, url);
                }
            }
            return responsestring;
        }


        public async Task<string> PostRequest(string url, string accept, HttpClient client, string body, string bearerToken)
        {
            string responseString;
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, url))
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
                requestMessage.Headers.Add("Accept", "application/*+xml;version=34.0");

                StringContent cont = new StringContent(body, Encoding.UTF8, "application/*+xml");
                requestMessage.Content = cont;
                HttpResponseMessage response = await client.SendAsync(requestMessage);
                responseString = await response.Content.ReadAsStringAsync();
            }
            return responseString;
        }

        public async Task<string> Login(string Name, string Password, HttpClient client)
        {
            //Login
            // don't Add new Deployment in this step
            string bearer = "";
            string url = "https://vcloud.claranet.de/api/login";
            Deployment newDeployment = new Deployment();
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                string name = "api@wibu-s";
                string pw = "7qbUQdfDYeiu";
                string authenticationString = $"{name}:{pw}";
                //authenticationString = $"{Name}:{Password}";
                var basicAuth = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", basicAuth);
                requestMessage.Headers.Accept.Clear();
                requestMessage.Headers.Add("Accept", "application/*+json;version=34.0");

                HttpResponseMessage response = await client.SendAsync(requestMessage);
                string responseString = await response.Content.ReadAsStringAsync();
                bearer = response.Headers.GetValues("X-VMWARE-VCLOUD-ACCESS-TOKEN").ToList()[0].ToString();
                newDeployment.BearerToken = bearer;
                bearer = response.Headers.GetValues("X-VMWARE-VCLOUD-ACCESS-TOKEN").ToList()[0].ToString();
                newDeployment = deployRepository.AddDeployment(newDeployment);
                deployRepository.SetToken(newDeployment.Id, bearer);
            }
            return bearer;
            
        }

    }
}
