using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace DataLibrary.BLL
{
    public static class OrgProcessor
    {
        /*
         * public static  GetOrgByOrgNo(int orgNo)
        {

        }
        */
        public static void CreateNewOrgSearchByParameters(string name, int fraAntAnsatte, int tilAntAnsatte, bool konkursParam, bool avviklingOrOpplosningParam, 
            bool avviklingParam, string hjemmesideParam)
        {
            Models.OrgSearchByParameters model = new Models.OrgSearchByParameters
            {
                navn = name,
                //organisasjonsnummer = orgNo,
                fraAntallAnsatte = fraAntAnsatte,
                tilAntallAnsatte = tilAntAnsatte,
                konkurs = konkursParam,
                underTvangsavviklingEllerTvangsopplosning = avviklingOrOpplosningParam,
                underAvvikling = avviklingParam,
                hjemmeside = hjemmesideParam,
                //SearchString
            };
            //model.createQueryString();
        }

        
    }
}
