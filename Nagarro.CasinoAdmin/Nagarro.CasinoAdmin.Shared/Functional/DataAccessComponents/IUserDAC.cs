using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.CasinoAdmin.Shared
{
    public interface IUserDAC : IDataAccessComponent
    {
        IUserDTO CreateUser(IUserDTO userDTO);
        IUserDTO AddMoney(IUserDTO userDTO);
        IList<IUserDTO> GetCurrentUsers();
        IUserDTO UpdateBlockedAmount(IUserDTO userDTO);
        IUserDTO UpdateBalance(IUserDTO userDTO);

    }
}
