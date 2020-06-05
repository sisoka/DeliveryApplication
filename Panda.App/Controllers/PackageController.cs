using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Panda.App.Models.Package;
using Panda.Data;
using Panda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panda.App.Controllers
{
    public class PackageController : Controller
    {
        private readonly PandaDbContext context;
        private readonly UserManager<PandaUser> userManager;
        public PackageController(PandaDbContext context, UserManager<PandaUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var bindingModel = new PackageCreateBindingModel();
            var recipients = this.userManager.Users.ToList();
            bindingModel.Recipients = recipients;
            return this.View(bindingModel);
        }

        [HttpPost]
        public IActionResult Create(PackageCreateBindingModel bindingModel)
        {
            return this.View();
        }
    }
}
