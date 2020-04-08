using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz10.Models;

namespace Quiz10.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<String>();
            foreach (Dawid g in Dawid.GetMyself())
            {
                string Name = g?.Name;
                string Whoarewe = g?.Whoarewe;
                //string relatedName = g?.Related.Name;
                results.Add(string.Format("Name of family member: {0}, and this is a little about them: {1}",
                    Name, Whoarewe));
            }
            return View(results);
        }
    }
}

