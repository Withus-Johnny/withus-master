using Newtonsoft.Json;
using RestSharp;
using Server.Environments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controllers
{
    public class APIController
    {
        private static APIController instance = new APIController();

        public static APIController Instance
        {
            get { return instance; }
        }

        private RestClient client;
        private RestRequest request;

        public APIController()
        {
            if (this.client == null)
            {
                this.client = new RestClient(Settings.APIServerBaseAddress);
            }
        }

        private async Task<RestResponse> SendPostRequestAsync(string endpoint, string payload)
        {
            request = new RestRequest(endpoint, Method.Post);
            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return await client.ExecuteAsync(request);
        }

        public async Task<RestResponse> Register(Dictionary<string, string> registerInfo)
        {
            string payload = JsonConvert.SerializeObject(registerInfo);

            var response = await SendPostRequestAsync("user/register", payload);
            return response;
        }
    }
}
