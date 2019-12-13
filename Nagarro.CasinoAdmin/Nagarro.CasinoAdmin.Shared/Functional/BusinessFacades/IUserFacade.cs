using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.CasinoAdmin.Shared
{
    public interface IUserFacade : IFacade
    {
        OperationResult<IUserDTO> CreateUser(IUserDTO userDTO);
        OperationResult<IUserDTO> AddMoney(IUserDTO userDTO);
        OperationResult<IList<IUserDTO>> GetCurrentUsers();
        OperationResult<IUserDTO >UpdateBlockedAmount(IUserDTO userDTO);
        OperationResult<IUserDTO> UpdateBalance(IUserDTO userDTO);
    }
}
