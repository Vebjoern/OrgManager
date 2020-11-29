using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrganizationManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.BLL;

namespace OrganizationManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*
        public IActionResult Privacy()
        {
            return View();
        }
        */

        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(Models.OrgSearchByParameters model)
        //Currently not working due to issue with parsing JSON data
        {
            if (ModelState.IsValid)
            {
                
                List<FullOrgEmbed> orgs = OrgProcessor.OrgSearchByParameters(model.navn, model.fraAntallAnsatte, model.tilAntallAnsatte, model.konkurs,
                model.underTvangsavviklingEllerTvangsopplosning, model.underAvvikling, model.hjemmeside).Result;
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult HentOrganisasjonsData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HentOrganisasjonsData(Models.OrgSearchByOrgNumber model)
        //Currently not working due to issue with parsing JSON data
        {
            if (ModelState.IsValid)
            {
                FullOrg org = new FullOrg();
                org = OrgProcessor.GetOrgByOrgNo(model.organisasjonsnummer).Result;
                int i = 1;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
