using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace DataLibrary
{
    public class BasicApiUsage
    {
        public static async Task<string> LoadOrg(int orgNr = 995412020)
        {
            //string url = "https://data.brreg.no/enhetsregisteret/api/enheter/";
            string url = orgNr.ToString();
            ApiEnhetsreg.InitializeClient();
            using (HttpResponseMessage response = await ApiEnhetsreg.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //BasicOrg org = new BasicOrg();
                    string org = "";
                    org = response.Content.ReadAsStringAsync().Result;
                    return org;
                }

                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
