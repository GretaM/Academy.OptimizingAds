using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OptimizingAds.Controllers
{
    public partial class loginasController : Controller
    {
        // 
        // GET: /HelloWorld/ 
   // [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ticketas(string ID, string Pasword)
        {
            try
            {
                string username = ID;
                string password = Pasword;
                com.adform.api.LoginData wr = new com.adform.api.LoginData();
                wr.UserName = username;
                wr.Password = password;
                com.adform.api.SecurityService atsakymas = new com.adform.api.SecurityService();
                string key = atsakymas.Login(wr);
                ViewBag.Message = key;
                return View();
            }
            catch (Exception)
            {
                return View();
            }

        }


        // 
        // GET: /HelloWorld/Welcome/ 


    }
}