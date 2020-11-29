using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DataLibrary.DAL;
using DataLibrary.Models;
using System.Net.Http.Json;

namespace DataLibrary.BLL
{
    public class OrgProcessor
    {
        public static async Task<FullOrg> GetOrgByOrgNo(int orgNo)
        //Currently not working due to issue with parsing JSON data
        {
            string APIResponseString = await ApiEnhetsregister.LoadOrgByOrgNo(orgNo);
            FullOrg org = JsonConvert.DeserializeObject<FullOrg>(APIResponseString);
            return org;
        }

        public static async Task<List<FullOrgEmbed>> OrgSearchByParameters(string name, int fraAntAnsatte, int tilAntAnsatte, bool konkursParam, bool avviklingOrOpplosningParam, 
            bool avviklingParam, string hjemmesideParam)
        //Currently not working due to issue with parsing JSON data
        {
            OrgSearchByParameters model = new OrgSearchByParameters
            {
                navn = name,
                fraAntallAnsatte = fraAntAnsatte,
                tilAntallAnsatte = tilAntAnsatte,
                konkurs = konkursParam,
                underTvangsavviklingEllerTvangsopplosning = avviklingOrOpplosningParam,
                underAvvikling = avviklingParam,
                hjemmeside = hjemmesideParam
            };

            string APIResponseString = ApiEnhetsregister.FindOrgsByQueryString(model.createQueryString()).Result;
            List<FullOrgEmbed> orgs = JsonConvert.DeserializeObject<List<FullOrgEmbed>>(APIResponseString);
            return orgs;
        }
        
    }
}
