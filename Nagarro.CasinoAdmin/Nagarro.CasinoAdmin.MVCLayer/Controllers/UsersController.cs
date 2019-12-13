using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using Nagarro.CasinoAdmin.Web.Shared;

namespace Nagarro.CasinoAdmin.MVCLayer.Controllers
{
    public class UsersController : Controller
    {

            // GET: Users
        public ActionResult Index(string searchName = null, string searchEmail = null,string searchContact = null)
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
                       // users = from r in readTask.Result orderby r.Name ascending select r; ;
                        users = readTask.Result.Where(r => (searchName == null || r.Name.Contains(searchName)) &&
                            (searchEmail == null || r.Email.Contains(searchEmail))&&
                            (searchContact == null ||  r.Contact.ToString().Contains(searchContact)));
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
            public ActionResult create(UserViewModel user, HttpPostedFileBase file)
            {
                if (ModelState.IsValid)
                {
                    if (file != null)
                    {
                        file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                              + file.FileName);
                        user.CopyOfId = file.FileName;
                    }
                    user.AccountBalance = 500;
                    user.BlockedAmount = 0;
                    user.UniqueId = GenerateId();

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
                }
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
            [HttpPost]

            public ActionResult Edit(UserViewModel user)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60455/api/users");

                    //HTTP POST
                    var putTask = client.PutAsJsonAsync<UserViewModel>("Users", user);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index");
                    }
                }
                return View(user);
            }
         [HttpPost]
            public ActionResult RechargeMoney(string amount, int id)
            {
                UserViewModel user = new UserViewModel();
                user.Id = id;
                user.AccountBalance = int.Parse(amount);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60455/api/users");

                    //HTTP POST
                    var putTask = client.PutAsJsonAsync<UserViewModel>("users", user);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index");
                    }
                }
                return View(user);
            }
         private string GenerateId()
         {
             long i = 1;
             foreach (byte b in Guid.NewGuid().ToByteArray())
             {
                 i *= ((int)b + 1);
             }
             return string.Format("{0:x}", i - DateTime.Now.Ticks);
         }
        
        }

    }