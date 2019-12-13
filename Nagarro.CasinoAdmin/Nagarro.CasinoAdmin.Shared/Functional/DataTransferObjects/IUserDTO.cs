using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.CasinoAdmin.Shared
{
    
    public interface IUserDTO :IDTO
    {
         int Id { get; set; }
         string Name { get; set; }
         string Contact { get; set; }
         DateTime DateOfBirth { get; set; }
         string Email { get; set; }
         string CopyOfId { get; set; }
         int AccountBalance { get; set; }
         int BlockedAmount { get; set; }
         string UniqueId { get; set; }
    }
}
