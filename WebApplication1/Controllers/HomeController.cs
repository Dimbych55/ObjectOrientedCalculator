using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Calculate;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
        new SelectListItem() { Value = "Sum", Text ="сложение" },
        new SelectListItem() { Value = "razn", Text ="вычитание" },
        new SelectListItem() { Value = "del", Text ="деление" },
        new SelectListItem() { Value = "umnog", Text ="умножение" },
        new SelectListItem() { Value = "step", Text ="степень" },
        new SelectListItem() { Value = "square", Text ="квадрат" }
            };
            return View();
        }



        [HttpPost]
        public ActionResult Index(double a, double b, string operation)
        {
            Operationscalculate C;
            C = new Operationscalculate();
            double result;
           
            
             
            result = C.Sum(a, b);
            result = C.razn(a, b);
            result = C.del(a, b);
            result = C.umnog(a, b);
            result = C.step(a, b);
            result = C.square(a);
           
            ViewBag.Result = result;

            ViewBag.Operation = new SelectListItem[]
            {
        new SelectListItem() { Value = "Sum", Text ="сложение" },
        new SelectListItem() { Value = "razn", Text ="вычитание" },
        new SelectListItem() { Value = "del", Text ="деление" },
        new SelectListItem() { Value = "umnog", Text ="умножение" },
        new SelectListItem() { Value = "step", Text ="степень" },
        new SelectListItem() { Value = "square", Text ="квадрат" }
            };
            return View();
            
        }

  
    }
}