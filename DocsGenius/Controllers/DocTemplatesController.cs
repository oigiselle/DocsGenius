using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DocsGenius.Data;
using DocsGenius.Models;
using System.Net.Http;

namespace DocsGenius.Controllers
{
    public class DocTemplatesController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<DocTemplate> docs;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/api/");
                //HTTP GET
                var responseTask = client.GetAsync("DocTemplates");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<DocTemplate>>();
                    readTask.Wait();

                    docs = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    docs = Enumerable.Empty<DocTemplate>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(docs);
        }

        public ActionResult Create(DocTemplate docTemplate)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5001/api/DocTemplates");
                //HTTP POST
                var responseTask = client.PostAsJsonAsync<DocTemplate>("DocTemplates", docTemplate);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(docTemplate);
        }
    
    

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}



