using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GithubAPI.Models;

namespace GithubAPI.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Details(string nome, String linguagem, string descricao, string atualizacao, string dono, string contribuidores)
        {
            ViewBag.nome = revert_trim(nome);
            ViewBag.linguagem = revert_trim(linguagem.Replace("%Sharp%", "#"));
            ViewBag.descricao = revert_trim(descricao);
            ViewBag.atualizacao = revert_trim(atualizacao);
            ViewBag.dono = revert_trim(dono);
            GithubAPI.Models.APIConsult consult = new GithubAPI.Models.APIConsult();
            ViewBag.contribuidores = consult.consultaContribuidores(contribuidores);
            return View();
        }

        public string revert_trim(string vlr)
        {
            if (vlr.Equals("undefined"))
            {
                return null;
            }
            while (vlr.IndexOf("$") != -1)
                vlr = vlr.Replace("$", " ");
            return vlr;
        }
    }
}