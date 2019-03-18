using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GithubAPI.Models;

namespace GithubAPI.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search(string nome)
        {
            return View("API", consultaRepositorios(nome));
        }

        public List<Repository> consultaRepositorios(string name)
        {
            GithubAPI.Models.APIConsult consult = new GithubAPI.Models.APIConsult();
            return consult.searchAPI("search/repositories?q=" + name);
        }
       

    }
}