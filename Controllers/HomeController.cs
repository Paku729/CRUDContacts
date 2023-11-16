using CRUDContacts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDContacts.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVC_DbContext dbContext;

        public HomeController(MVC_DbContext DbContext)
        {
            this.dbContext = DbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

   
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Contact request)
        {
            var contact = new Contact()
            {
                id = Guid.NewGuid(),
                Name = request.Name,
                MobilePhone = request.MobilePhone,
                JobTitle = request.JobTitle,
                BirthDate = request.BirthDate
            };

            await dbContext.Contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
