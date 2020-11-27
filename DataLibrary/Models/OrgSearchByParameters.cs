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
            StringBuilder temp = new StringBuilder("?", 512);
            if (this.navn != "")
            {
                temp.Append("navn=" + navn + "&");
            }
            if (this.fraAntallAnsatte > 0)
            {
                temp.Append("fraAntallAnsatte=" + fraAntallAnsatte.ToString() + "&");
            }
            if (this.tilAntallAnsatte < 9999999)
            {
                temp.Append("tilAntallAnsatte=" + tilAntallAnsatte.ToString() + "&");
            }
            if (this.konkurs)
            {
                temp.Append("konkurs=true&");
            }
            if (this.underTvangsavviklingEllerTvangsopplosning)
            {
                temp.Append("underTvangsavviklingEllerTvangsopplosning=true&");
            }
            if (this.underAvvikling)
            {
                temp.Append("underAvvikling=true&");
            }
            if (this.hjemmeside != "")
            {
                temp.Append("hjemmeside=" + hjemmeside + "&");
            }
            temp.Length--;  //Practically removes last trailing '&' char
            return temp.ToString();
        }

    }
}
