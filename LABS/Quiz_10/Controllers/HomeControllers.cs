using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test10.Model;
//using System.Collections.Generic;
//using LanguageFeatures.Models;


namespace Test10.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<String>();
            foreach (Myself g in Myself.GetMyself())
            {
                string Name = g?.Name;
                string HowWeMet = g?.HowWeMet;
                //string relatedName = g?.Related.Name;
                results.Add(string.Format("Name of Bestfriends: {0}, How We Met: {1}",
                    Name, HowWeMet));
            }
            return View(results);
        }
    }
}