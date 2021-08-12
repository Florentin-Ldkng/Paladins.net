using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net
{
    public class RequestHandler
    {
        private HttpClient _client;

        protected internal dynamic Call<T>(string Url)
        {
            Console.WriteLine(Url);
            HttpResponseMessage response = _client.GetAsync(Url).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsAsync<T>().Result;
                return dataObjects;
            }
            else
            {
                throw new ApiErrorException((int)response.StatusCode, response.ReasonPhrase);
            }
        }

        protected internal void ClientDefaultSetup()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public class ApiErrorException : Exception
        {
            public int ErrorCode;
            public ApiErrorException(int errorCode, string errorMessage) : base(errorMessage)
            {
                this.ErrorCode = errorCode;
            }
        }
    }
}
