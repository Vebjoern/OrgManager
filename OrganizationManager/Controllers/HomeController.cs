using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrganizationManager.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary;
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
        {
            if (ModelState.IsValid)
            {
                OrgProcessor.CreateNewOrgSearchByParameters(model.navn, model.fraAntallAnsatte, model.tilAntallAnsatte, model.konkurs,
                    model.underTvangsavviklingEllerTvangsopplosning, model.underAvvikling, model.hjemmeside);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult HentOrganisasjonsData()
        {
            return View();
        }



        /*public async Task<IActionResult> FinnOrganisasjon()
        {
            int orgNr = 995412020;
            //BasicOrganization org = new BasicOrganization();
            //org.Notat = await BasicApiUsage.LoadOrg(orgNr);
            //ViewBag.Message = org.Notat;
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
