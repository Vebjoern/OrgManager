using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace DataLibrary.DAL
{
    public class ApiEnhetsregister
    {
        public static async Task<string> LoadOrgByOrgNo(int orgNr)
        {
            string url = "https://data.brreg.no/enhetsregisteret/api/enheter/" + orgNr.ToString();
            ApiHelper.InitializeClient();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string s = await response.Content.ReadAsStringAsync();

                    return s;
                }

                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<string> FindOrgsByQueryString(string query)
        {
            string url = "https://data.brreg.no/enhetsregisteret/api/enheter" + query;
            ApiHelper.InitializeClient();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string s = await response.Content.ReadAsStringAsync();

                    return s;
                }

                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
