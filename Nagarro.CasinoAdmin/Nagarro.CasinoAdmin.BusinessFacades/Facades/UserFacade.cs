using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.CasinoAdmin.Shared;

namespace Nagarro.CasinoAdmin.BusinessFacades
{
    public class UserFacade : FacadeBase, IUserFacade
    {
        public UserFacade()
            : base(FacadeType.UserFacade)
        {

        }

        public OperationResult<IUserDTO> CreateUser(IUserDTO userDTO)
        {
            IUserBDC userBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return userBDC.CreateUser(userDTO);
        }


        public OperationResult<IList<IUserDTO>> GetCurrentUsers()
        {
            IUserBDC userBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return userBDC.GetCurrentUsers();
        }


        public OperationResult<IUserDTO> AddMoney(IUserDTO userDTO)
        {
            IUserBDC userBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return userBDC.AddMoney(userDTO);
        }

        public OperationResult<IUserDTO> UpdateBlockedAmount(IUserDTO userDTO)
        {
            IUserBDC userBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return userBDC.UpdateBlockedAmount(userDTO);
        }

        public OperationResult<IUserDTO> UpdateBalance(IUserDTO userDTO)
        {
            IUserBDC userBDC = (IUserBDC)BDCFactory.Instance.Create(BDCType.UserBDC);
            return userBDC.UpdateBalance(userDTO);
        }
    }
}
