using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GithubAPI.Models;


namespace GithubAPI.Controllers
{
    public class APIController : Controller
    {

        // GET: API
        public ActionResult Index(String nome)
        {
            GithubAPI.Models.APIConsult consult = new GithubAPI.Models.APIConsult();
            if (nome == null) {
                //ViewBag.repositorios = consult.consultaAPI("users/RafaelRabeloO/repos");
            }
            else {
                //ViewBag.repositorios = consult.searchAPI(nome);
            }
            return View();
        }

    }
}