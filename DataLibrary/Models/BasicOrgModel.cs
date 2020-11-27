using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class BasicOrgModel
    {
        public int organisasjonsnummer { get; set; }
        public string navn { get; set; }
        public List<string> organisasjonsform { get; set; }
        public string hjemmeside { get; set; }
        public string registreringsdatoEnhetsregisteret { get; set; }
        public List<string> naeringskode1 { get; set; }
        public int antallAnsatte { get; set; }
        public List<string> forretningsadresse { get; set; }
        public string stiftelsesdato { get; set; }
        public List<string> institusjonellSektorkode { get; set; }
        public bool konkurs { get; set; }
        public bool underAvvikling { get; set; }
        public bool underTvangsavviklingEllerTvangsopplosning { get; set; }
        public string maalform { get; set; }

    }
}
