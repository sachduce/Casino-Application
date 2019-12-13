using Nagarro.CasinoAdmin.Web.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nagarro.CasinoAdmin.Shared;
using System.Web.Http.Cors;
namespace Nagarro.CasinoAdmin.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        public IHttpActionResult GetAllUsers()
    {
        List<UserViewModel> userList = new List<UserViewModel>();
        IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IList<IUserDTO>> result = userFacade.GetCurrentUsers();
            if (result.IsValid())
            {
                foreach (var item in result.Data)
                {
                    UserViewModel user = new UserViewModel();
                    DTOConverter.FillViewModelFromDTO(user, item);
                    userList.Add(user);
                }
                return Json(userList);
            }
            return NotFound();
             
    }
        public IHttpActionResult GetUser(int id)
        {
            
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IList<IUserDTO>> result = userFacade.GetCurrentUsers();
            if (result.IsValid())
            {
                foreach (var item in result.Data)
                {
                    if (id == item.Id)
                    {
                        UserViewModel user = new UserViewModel();
                        DTOConverter.FillViewModelFromDTO(user, item);
                        return Json(user);
                    }
                    
                    
                }
                
            }
            return NotFound();

        }

        public IHttpActionResult PostUser(UserViewModel user)
        {
            
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            DTOConverter.FillDTOFromViewModel(userDTO, user);
            OperationResult<IUserDTO> result = userFacade.CreateUser(userDTO);
            return Json(user);
        }
        public IHttpActionResult Put( UserViewModel user)
        {
           
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            DTOConverter.FillDTOFromViewModel(userDTO, user);
            OperationResult<IUserDTO> result = userFacade.AddMoney(userDTO);
            if (result.IsValid())
            {
                DTOConverter.FillViewModelFromDTO(user, result.Data);
                return Json(user);
            }
            return NotFound();
        }

        public IHttpActionResult GetUser(string uniqueId)
        {
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            OperationResult<IList<IUserDTO>> result = userFacade.GetCurrentUsers();
            if (result.IsValid())
            {
                foreach (var item in result.Data)
                {
                    if (uniqueId == item.UniqueId)
                    {
                        UserViewModel user = new UserViewModel();
                        DTOConverter.FillViewModelFromDTO(user, item);
                        return Json(user);
                    }
                }

            }
            return NotFound();

        }
    
        public IHttpActionResult Put(int id, int blockedAmount)
        {
           
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            userDTO.Id = id;
            userDTO.BlockedAmount = blockedAmount;
            OperationResult<IUserDTO> result = userFacade.UpdateBlockedAmount(userDTO);
            UserViewModel user = new UserViewModel();
            if (result.IsValid())
            {
                DTOConverter.FillViewModelFromDTO(user, result.Data);
                return Json(user);
            }
            return NotFound();
        }
        public IHttpActionResult Put(int id, int blockedAmount, int accountBalance)
        {
            
            IUserFacade userFacade = (IUserFacade)FacadeFactory.Instance.Create(FacadeType.UserFacade);
            IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
            userDTO.Id = id;
            userDTO.BlockedAmount = blockedAmount;
            userDTO.AccountBalance = accountBalance;
            OperationResult<IUserDTO> result = userFacade.UpdateBalance(userDTO);
            UserViewModel user = new UserViewModel();
            if (result.IsValid())
            {
                DTOConverter.FillViewModelFromDTO(user, result.Data);
                return Json(user);
            }
            return NotFound();
        }
}
}
