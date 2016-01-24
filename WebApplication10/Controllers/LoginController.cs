using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
using WebApplication10.ViewModels;

namespace WebApplication10.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Home/
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            var vm = new LoginViewModel();
            vm.Title = " Введите данные,*ля!";

            return View(vm);
        }
        
    }
}