using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace OrganizationManager.Models
{
    public class OrgSearchByOrgNumber
    {
        [Display(Name = "Organisasjonsnummer")]
        [Required]
        [Range(100000000, 999999999, ErrorMessage ="Organisasjonsnummeret må inneholde nøyaktig 9 siffer.")]
        public int organisasjonsnummer { get; set; }
    }
}
