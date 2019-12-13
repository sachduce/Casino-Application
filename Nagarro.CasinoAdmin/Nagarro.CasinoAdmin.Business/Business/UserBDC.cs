using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.CasinoAdmin.Shared;

namespace Nagarro.CasinoAdmin.Business
{
    public class UserBDC : BDCBase, IUserBDC
    {
        public UserBDC()
            : base(BDCType.UserBDC)
        {

        }

        public OperationResult<IUserDTO> AddMoney(IUserDTO userDTO)
        {
            OperationResult<IUserDTO> retVal = null;
            try
            {
                IUserDAC userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO user = userDAC.AddMoney(userDTO);
                if (user != null)
                {
                    retVal = OperationResult<IUserDTO>.CreateSuccessResult(user);
                }
                else
                {
                    retVal = OperationResult<IUserDTO>.CreateFailureResult(ValidationConstants.GetCurrentNoticeFailure);
                }

            }
            catch (DACException dacException)
            {
                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacException.Message, dacException.StackTrace);
            }
            catch (Exception exception)
            {
                ExceptionManager.HandleException(exception);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(exception.Message, exception.StackTrace);
            }
            return retVal;
        }
           

        public OperationResult<IList<IUserDTO>> GetCurrentUsers()
        {
            OperationResult<IList<IUserDTO>> getUsersRetVal = null;
            try
            {
                IUserDAC userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IList<IUserDTO> usersList = userDAC.GetCurrentUsers();
                if (usersList != null)
                {
                    getUsersRetVal = OperationResult<IList<IUserDTO>>.CreateSuccessResult(usersList);
                }
                else
                {
                    getUsersRetVal = OperationResult<IList<IUserDTO>>.CreateFailureResult(ValidationConstants.GetCurrentNoticeFailure);
                }

            }
            catch (DACException dacException)
            {
                getUsersRetVal = OperationResult<IList<IUserDTO>>.CreateErrorResult(dacException.Message, dacException.StackTrace);
            }
            catch (Exception exception)
            {
                ExceptionManager.HandleException(exception);
                getUsersRetVal = OperationResult<IList<IUserDTO>>.CreateErrorResult(exception.Message, exception.StackTrace);
            }
            return getUsersRetVal;
        }

        public OperationResult<IUserDTO> CreateUser(IUserDTO userDTO)
        {
            OperationResult<IUserDTO> retVal = null;
            try
            {
                IUserDAC userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO user = userDAC.CreateUser(userDTO);
                if (user != null)
                {
                    retVal = OperationResult<IUserDTO>.CreateSuccessResult(user);
                }
                else
                {
                    retVal = OperationResult<IUserDTO>.CreateFailureResult(ValidationConstants.GetCurrentNoticeFailure);
                }

            }
            catch (DACException dacException)
            {
                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacException.Message, dacException.StackTrace);
            }
            catch (Exception exception)
            {
                ExceptionManager.HandleException(exception);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(exception.Message, exception.StackTrace);
            }
            return retVal;

        }


        public OperationResult<IUserDTO> UpdateBlockedAmount(IUserDTO userDTO)
        {
            OperationResult<IUserDTO> retVal = null;
            try
            {
                IUserDAC userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO user = userDAC.UpdateBlockedAmount(userDTO);
                if (user != null)
                {
                    retVal = OperationResult<IUserDTO>.CreateSuccessResult(user);
                }
                else
                {
                    retVal = OperationResult<IUserDTO>.CreateFailureResult(ValidationConstants.GetCurrentNoticeFailure);
                }

            }
            catch (DACException dacException)
            {
                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacException.Message, dacException.StackTrace);
            }
            catch (Exception exception)
            {
                ExceptionManager.HandleException(exception);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(exception.Message, exception.StackTrace);
            }
            return retVal;
        }

        public OperationResult<IUserDTO> UpdateBalance(IUserDTO userDTO)
        {
            OperationResult<IUserDTO> retVal = null;
            try
            {
                IUserDAC userDAC = (IUserDAC)DACFactory.Instance.Create(DACType.UserDAC);
                IUserDTO user = userDAC.UpdateBalance(userDTO);
                if (user != null)
                {
                    retVal = OperationResult<IUserDTO>.CreateSuccessResult(user);
                }
                else
                {
                    retVal = OperationResult<IUserDTO>.CreateFailureResult(ValidationConstants.GetCurrentNoticeFailure);
                }

            }
            catch (DACException dacException)
            {
                retVal = OperationResult<IUserDTO>.CreateErrorResult(dacException.Message, dacException.StackTrace);
            }
            catch (Exception exception)
            {
                ExceptionManager.HandleException(exception);
                retVal = OperationResult<IUserDTO>.CreateErrorResult(exception.Message, exception.StackTrace);
            }
            return retVal;
        }
    }
}
