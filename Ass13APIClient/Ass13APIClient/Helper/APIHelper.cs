using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Ass13APIClient.Helper
{
    public class APIHelper
    {
        string serviceUrl = "http://localhost/Ass23_POPSApi/";
        public T HttpGet<T>(string path, Dictionary<string, object> parameters, string mediaType)
        {
            UriBuilder builder = new UriBuilder();
            builder.Path = path;
            builder.Query = string.Join("&", parameters.Where(p => p.Value != null)
                            .Select(p => string.Format(CultureInfo.InvariantCulture, "{0}={1}",
                                 System.Web.HttpUtility.UrlEncode(p.Key),
                                 HttpUtility.UrlEncode(p.Value.ToString()))));
            string pathQuery = builder.Uri.PathAndQuery;
            pathQuery = pathQuery.StartsWith("/", StringComparison.Ordinal) ? pathQuery.TrimStart('/') : pathQuery;
            return HttpGet<T>(pathQuery, mediaType);
        }


        private T HttpGet<T>(string pathAndQuery, string mediaType)
        {
            T result;
            serviceUrl = string.IsNullOrWhiteSpace(serviceUrl) ? ConfigurationManager.AppSettings.Get("ServiceUrl") : serviceUrl;
            using (HttpClientHandler clientHandler = new HttpClientHandler())
            {
                clientHandler.UseDefaultCredentials = true;

                using (HttpClient client = new HttpClient(clientHandler))
                {
                   
                    client.BaseAddress = new Uri(serviceUrl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));

                    var response = client.GetAsync(pathAndQuery).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        result = response.Content.ReadAsAsync<T>().Result;
                    }
                    else
                    {
                       
                        string msg = response.Content.ReadAsStringAsync().Result;
                        throw new HttpException(msg);
                    }
                }
            }
            return result;
        }


        public T HttpPost<T, TK>(string pathAndQuery, TK data, string mediaType)
        {
            T result;           

            using (HttpClientHandler clientHandler = new HttpClientHandler())
            {
                clientHandler.UseDefaultCredentials = true;

                using (HttpClient client = new HttpClient(clientHandler))
                {                   
                    client.BaseAddress = new Uri(serviceUrl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
                    client.DefaultRequestHeaders.ExpectContinue = false;
                    var response = client.PostAsJsonAsync(pathAndQuery, data).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        result = response.Content.ReadAsAsync<T>().Result;
                    }
                    else
                    {
                        string msg = response.Content.ReadAsStringAsync().Result;
                        throw new HttpException(string.Format(CultureInfo.InvariantCulture, "Status Code {0} Reason Phrase {1} Message {2}", response.StatusCode, response.ReasonPhrase, msg));
                    }
                }
            }
            return result;
        }
    }
}