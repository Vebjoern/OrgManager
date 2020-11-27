using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using DataLibrary.DAL;

namespace DataLibrary.BLL
{
    public static class OrgProcessor
    {
        public static void GetOrgByOrgNo(int orgNo)
        {
            BasicApiUsage.LoadOrgByOrgNo(orgNo);
        }

        public static async void  CreateNewOrgSearchByParameters(string name, int fraAntAnsatte, int tilAntAnsatte, bool konkursParam, bool avviklingOrOpplosningParam, 
            bool avviklingParam, string hjemmesideParam)
        {
            Models.OrgSearchByParameters model = new Models.OrgSearchByParameters
            {
                navn = name,
                fraAntallAnsatte = fraAntAnsatte,
                tilAntallAnsatte = tilAntAnsatte,
                konkurs = konkursParam,
                underTvangsavviklingEllerTvangsopplosning = avviklingOrOpplosningParam,
                underAvvikling = avviklingParam,
                hjemmeside = hjemmesideParam,
            };
            await BasicApiUsage.FindOrgsByQueryString(model.createQueryString());
        }

        
    }
}
