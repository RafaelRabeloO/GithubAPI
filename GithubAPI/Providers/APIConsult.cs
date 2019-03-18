using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace GithubAPI.Models
{
    public class APIConsult
    {
        private static readonly HttpClient client = new HttpClient();
        static string ApiBaseUrl = "https://api.github.com/";

        public List<Repository> consultaAPI(string path)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + path);
                httpWebRequest.ContentType = "application / vnd.github.v3 + json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "RafaelRabeloO";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<List<Repository>>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Repository> searchAPI(string nome)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + "search/repositories?q=" + nome);
                httpWebRequest.ContentType = "application / vnd.github.v3 + json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "RafaelRabeloO";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<Search>(streamReader.ReadToEnd()).items;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Contributor> consultaContribuidores(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application / vnd.github.v3 + json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "RafaelRabeloO";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<List<Contributor>>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}