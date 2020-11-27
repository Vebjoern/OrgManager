using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DataLibrary.Models
{
    public class OrgSearchByParameters
    {
        public string navn { get; set; }
        //public int? organisasjonsnummer { get; set; }
        public int fraAntallAnsatte { get; set; }
        public int tilAntallAnsatte{ get; set; }
        public bool konkurs { get; set; }
        public bool underTvangsavviklingEllerTvangsopplosning { get; set; }
        public bool underAvvikling { get; set; }
        //public List<string> organisasjonsform { get; set; }
        public string hjemmeside { get; set; }
        //public string postadresse.kommunenummer { get; set; }
        //public List<string> naeringskode { get; set; }
        //public string SearchString;

        public string createQueryString ()
        {
            string s = "";
            return s;
        }

    }
}
