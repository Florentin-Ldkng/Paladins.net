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
        private HttpClient client = new HttpClient();
        public dynamic Call<T>(string Url)
        {
            Console.WriteLine(Url);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(Url).Result;
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
