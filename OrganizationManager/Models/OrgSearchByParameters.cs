using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrganizationManager.Models
{
    public class OrgSearchByParameters
    {
        [Display(Name = "Navn")]
        public string navn { get; set; } = "";
        [Display(Name = "Fra antall ansatte")]
        public int fraAntallAnsatte { get; set; } = 0;
        [Display(Name = "Til antall ansatte")]
        public int tilAntallAnsatte { get; set; } = 9999999;
        [Display(Name = "Hjemmeside")]
        public string hjemmeside { get; set; } = "";
        [Display(Name = "Konkurs")]
        public bool konkurs { get; set; }
        [Display(Name = "Under tvangsavvikling eller tvangsoppløsning")]
        public bool underTvangsavviklingEllerTvangsopplosning { get; set; }
        [Display(Name = "Under avvikling")]
        public bool underAvvikling { get; set; }
        
    }
}
