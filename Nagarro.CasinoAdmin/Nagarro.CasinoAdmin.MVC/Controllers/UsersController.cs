using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using Nagarro.CasinoAdmin.Web.Shared;
using Nagarro.CasinoAdmin.MVC.Models;
using System.Web.Mvc;

namespace Nagarro.CasinoAdmin.MVC.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            IEnumerable<UserViewModel> users = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60455/api/");

                var responseTask = client.GetAsync("Users");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<UserViewModel>>();
                    readTask.Wait();
                    users = readTask.Result;
                }
                else  
                {
                    users = Enumerable.Empty<UserViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(users);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult create(UserViewModel user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60455/api/users");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<UserViewModel>("Users", user);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(user);
        }

        public ActionResult Edit(int id)
        {
            UserViewModel user = null;
         using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:60455/api/");
            var responseTask = client.GetAsync("users?id=" + id.ToString());
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<UserViewModel>();
                readTask.Wait();
                user = readTask.Result;
            }
        }
        return View(user);
    }
}
}
