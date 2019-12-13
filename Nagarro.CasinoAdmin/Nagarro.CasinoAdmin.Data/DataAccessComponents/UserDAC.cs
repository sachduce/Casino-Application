using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.CasinoAdmin.Shared;
using Nagarro.CasinoAdmin.EntityDataModel;
using Nagarro.CasinoAdmin.EntityDataModel.EntityModel;



namespace Nagarro.CasinoAdmin.Data
{
    public class UserDAC : DACBase, IUserDAC
    {
        public UserDAC()
            : base(DACType.UserDAC)
        {

        }

        public IUserDTO AddMoney(IUserDTO userDTO)
        {
            IUserDTO retVal = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO); 
            try
            {
                using ( CasinoUserEntities context = new CasinoUserEntities())
                {
                    User user = context.Users.Find(userDTO.Id);
                    user.AccountBalance = user.AccountBalance + userDTO.AccountBalance;
                    context.SaveChanges();
                    EntityConverter.FillDTOFromEntity(user, retVal);
                }
                
            }

            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }

            return retVal;
        }


        public IList<IUserDTO> GetCurrentUsers()
        {
            IList<IUserDTO> userDTOList = new List<IUserDTO>();
            try
            {
                using (CasinoUserEntities context = new CasinoUserEntities())
                {
                   // var model = from r in context.Users orderby r.Name ascending select r;
                    foreach (var user in context.Users)
                    {
                        IUserDTO userDTO = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO);
                        
                            EntityConverter.FillDTOFromEntity(user,userDTO );
                            userDTOList.Add(userDTO);
                        }
                    }
                }
            
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }
            return userDTOList;
        }

        public IUserDTO CreateUser(IUserDTO userDTO)
        {
            IUserDTO retVal = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO); 
            try
            {
                using (CasinoUserEntities context = new CasinoUserEntities())
                {
                    User user = new User();
                    EntityConverter.FillEntityFromDTO(userDTO, user);
                    context.Users.Add(user);
                    context.SaveChanges();
                    retVal = userDTO;
                }

            }

            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }

            return retVal;
        }


        public IUserDTO UpdateBlockedAmount(IUserDTO userDTO)
        {
            IUserDTO retVal = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO); 
            try
            {
                using (CasinoUserEntities context = new CasinoUserEntities())
                {
                    User user = context.Users.Find(userDTO.Id);
                    user.BlockedAmount = user.BlockedAmount + userDTO.BlockedAmount;
                    context.SaveChanges();
                    EntityConverter.FillDTOFromEntity(user, retVal);
                }
            }

            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }

            return retVal;
        }

        public IUserDTO UpdateBalance(IUserDTO userDTO)
        {
            IUserDTO retVal = (IUserDTO)DTOFactory.Instance.Create(DTOType.UserDTO); 
            try
            {
                using (CasinoUserEntities context = new CasinoUserEntities())
                {
                    User user = context.Users.Find(userDTO.Id);
                    user.BlockedAmount = user.BlockedAmount + userDTO.BlockedAmount;
                    user.AccountBalance = user.AccountBalance + userDTO.AccountBalance;
                    context.SaveChanges();
                    EntityConverter.FillDTOFromEntity(user, retVal);
                }

            }

            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException(ex.Message);
            }

            return retVal;
        }
    }
}
