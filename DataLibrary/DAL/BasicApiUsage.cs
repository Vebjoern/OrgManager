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
        public static async Task<object> LoadOrgByOrgNo(int orgNr = 995412020)
        {
            string url = "https://data.brreg.no/enhetsregisteret/api/enheter/" + orgNr.ToString();
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
