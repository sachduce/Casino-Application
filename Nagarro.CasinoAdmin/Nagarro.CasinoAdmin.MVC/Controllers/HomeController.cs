using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nagarro.CasinoAdmin.Web.Shared;
using Nagarro.CasinoAdmin.Shared;
using Nagarro.CasinoAdmin.MVC.Models;

namespace Nagarro.CasinoAdmin.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IList<IUserDTO>> getUsers = userFacade.GetCurrentUsers();
            List<UserViewModel> userList = new List<UserViewModel>();
            if (getUsers.IsValid())
            {
                foreach (var item in getUsers.Data)
                {
                    UserViewModel user = new UserViewModel();
                    DTOConverter.FillViewModelFromDTO(user, item);
                    userList.Add(user);
                }
            }
            
            return View(userList);
        }
    }
}