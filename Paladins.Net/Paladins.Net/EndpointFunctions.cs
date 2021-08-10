using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paladins.Net.Structures;

namespace Paladins.Net
{
    public static class EndpointFunctions
    {
        public static string BuildUrl(string Url, string function, params string[] inputs)
        {
            if (function == "createsession")
            {
                return $"{Url}/{Credentials.devId}/{CreateSignature(function)}/{GetTime()}";
            }
            else if(function == "getplayerbatch" || function == "getmatchdetailsbatch")
            {
                return $"{Url}/{Credentials.devId}/{CreateSignature(function)}/{Credentials.session}/{GetTime()}/" + string.Join(',', inputs);
            }
            else
            {
                return $"{Url}/{Credentials.devId}/{CreateSignature(function)}/{Credentials.session}/{GetTime()}/" + string.Join('/', inputs);
            }
        }
        public static string GetMd5Hash(string input)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            bytes = md5.ComputeHash(bytes);
            var sb = new System.Text.StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        public static string CreateSignature(string function)
        {
            return GetMd5Hash(Credentials.devId + function + Credentials.oAuth + GetTime());
        }
        public static string GetTime()
        {
            return DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmss");
        }
    }
}
