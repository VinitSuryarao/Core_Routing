using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //// Without Routing
        //[HttpPost]
        //public IActionResult OnSubmit()
        //{
        //    return View("Index");
        //}

        //// Virtual URL Partial Route
        //[HttpPost("fkdjfkdb4783248bjdbf")]
        //public IActionResult OnSubmit()
        //{
        //    return View("Index");
        //}

        // Actual Routing With Route Define
        [HttpPost("fkdjfkdb4783248bjdbf", Name ="client_Submit")]
        public IActionResult OnSubmit()
        {
            return View("Index");
        }
    }
}