using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace DataLibrary.DAL
{
    public class BasicApiUsage
    {
        public static async Task<object> LoadOrgByOrgNo(int orgNr = 995412020)
        {
            string url = "/enheter/" + orgNr.ToString();
            ApiEnhetsreg.InitializeClient();
            using (HttpResponseMessage response = await ApiEnhetsreg.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    
                    //org = response.Content.ReadAsStringAsync().Result;
                    return response;
                }

                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<object> FindOrgsByQueryString(string query)
        {
            string url = "/enheter/" + query;
            ApiEnhetsreg.InitializeClient();
            using (HttpResponseMessage response = await ApiEnhetsreg.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    //org = response.Content.ReadAsStringAsync().Result;
                    return response;
                }

                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
