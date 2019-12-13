using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.CasinoAdmin.Shared
{
    /// <summary>
    /// The Facade Types
    /// </summary>
    public enum FacadeType
    {
       
        /// <summary>
        /// Notice Facade
        /// </summary>
        [QualifiedTypeName("Nagarro.CasinoAdmin.BusinessFacades.dll", "Nagarro.CasinoAdmin.BusinessFacades.UserFacade")]
        UserFacade = 1

       
     
    }
}
