using System.Collections.Generic;
using DocsGenius.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocsGenius.Controllers
{
    public class DocsTemplatesController : Controller
    {
        public IActionResult Index()
        {
            List<DocsTemplate> list = new List<DocsTemplate>();

            list.Add(new DocsTemplate { Id = 1, Link = "www.google.com.br", Name = "Template1", Description = "This is a sales proposal" });
            list.Add(new DocsTemplate { Id = 2, Link = "www.google.com.br", Name = "Template2", Description = "This is a service agreement"});
            return View(list);
        }
    }
}
